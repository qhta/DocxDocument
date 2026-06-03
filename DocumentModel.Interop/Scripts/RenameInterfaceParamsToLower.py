import os
import re

ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
TARGET_DIRS = {os.path.join(ROOT, "CoreClasses"), os.path.join(ROOT, "CoreInterfaces"), os.path.join(ROOT, "WordClasses"), os.path.join(ROOT, "WordInterfaces"), os.path.join(ROOT, "BaseClasses"), os.path.join(ROOT, "BaseInterfaces")}
DECL_KEYWORDS = ("public", "private", "protected", "internal")
CONTROL_WORDS = {"if", "for", "foreach", "while", "switch", "catch", "lock", "using", "return", "new", "nameof", "sizeof", "typeof"}


def is_ident_char(c: str) -> bool:
		return c.isalnum() or c == "_" or c == "@"


def find_matching(text: str, start: int, open_ch: str, close_ch: str) -> int:
		depth = 0
		i = start
		n = len(text)
		while i < n:
				ch = text[i]
				if ch == open_ch:
						depth += 1
				elif ch == close_ch:
						depth -= 1
						if depth == 0:
								return i
				i += 1
		return -1


def split_top_level(s: str, sep: str = ","):
		parts = []
		start = 0
		a = b = c = 0
		i = 0
		while i < len(s):
				ch = s[i]
				if ch == "<":
						a += 1
				elif ch == ">" and a > 0:
						a -= 1
				elif ch == "(":
						b += 1
				elif ch == ")" and b > 0:
						b -= 1
				elif ch == "[":
						c += 1
				elif ch == "]" and c > 0:
						c -= 1
				elif ch == sep and a == 0 and b == 0 and c == 0:
						parts.append(s[start:i])
						start = i + 1
				i += 1
		parts.append(s[start:])
		return parts


def split_default(seg: str):
		a = b = c = 0
		for i, ch in enumerate(seg):
				if ch == "<":
						a += 1
				elif ch == ">" and a > 0:
						a -= 1
				elif ch == "(":
						b += 1
				elif ch == ")" and b > 0:
						b -= 1
				elif ch == "[":
						c += 1
				elif ch == "]" and c > 0:
						c -= 1
				elif ch == "=" and a == 0 and b == 0 and c == 0:
						return seg[:i], seg[i:]
		return seg, ""


def lower_first(name: str) -> str:
		return name[:1].lower() + name[1:] if name else name


def rename_param_segment(seg: str):
		left, default_part = split_default(seg)
		m = re.search(r"(@?[A-Za-z_][A-Za-z0-9_]*)\s*$", left)
		if not m:
				return seg, None
		pname = m.group(1)
		if pname in {"this", "base"}:
				return seg, None
		bare = pname[1:] if pname.startswith("@") else pname
		if not bare or not bare[0].isupper():
				return seg, None
		new_bare = lower_first(bare)
		new_name = ("@" + new_bare) if pname.startswith("@") else new_bare
		new_left = left[: m.start(1)] + new_name + left[m.end(1) :]
		return new_left + default_part, (bare, new_bare)


def get_word_before_paren(text: str, paren_index: int):
		i = paren_index - 1
		while i >= 0 and text[i].isspace():
				i -= 1
		end = i + 1
		while i >= 0 and is_ident_char(text[i]):
				i -= 1
		return text[i + 1 : end]


def find_decl_terminator(text: str, start: int):
		i = start
		n = len(text)
		while i < n:
				if text.startswith("=>", i):
						return "=>", i
				ch = text[i]
				if ch == "{":
						return "{", i
				if ch == ";":
						return ";", i
				i += 1
		return None, -1


def apply_word_replacements(segment: str, replacements):
		changed = segment
		for old, new in replacements:
				changed = re.sub(rf"\b{re.escape(old)}\b", new, changed)
		return changed


def process_file(path: str):
		with open(path, "r", encoding="utf-8") as f:
				text = f.read()

		edits = []
		i = 0
		n = len(text)

		while i < n:
				p = text.find("(", i)
				if p == -1:
						break

				line_start = text.rfind("\n", 0, p) + 1
				line_prefix = text[line_start:p]
				if not any(k in line_prefix for k in DECL_KEYWORDS):
						i = p + 1
						continue

				name = get_word_before_paren(text, p)
				if not name or name in CONTROL_WORDS:
						i = p + 1
						continue

				close = find_matching(text, p, "(", ")")
				if close == -1:
						i = p + 1
						continue

				param_text = text[p + 1 : close]
				parts = split_top_level(param_text, ",")
				replacements = []
				new_parts = []
				changed_params = False

				for part in parts:
						new_part, repl = rename_param_segment(part)
						new_parts.append(new_part)
						if repl is not None and repl[0] != repl[1]:
								replacements.append(repl)
								changed_params = True

				if not changed_params:
						i = close + 1
						continue

				new_param_text = ",".join(new_parts)
				edits.append((p + 1, close, new_param_text))

				term_kind, term_pos = find_decl_terminator(text, close + 1)
				if term_kind == "=>":
						end_expr = text.find(";", term_pos + 2)
						if end_expr != -1:
								seg = text[term_pos:end_expr]
								new_seg = apply_word_replacements(seg, replacements)
								if new_seg != seg:
										edits.append((term_pos, end_expr, new_seg))
				elif term_kind == "{":
						end_block = find_matching(text, term_pos, "{", "}")
						if end_block != -1:
								seg = text[term_pos : end_block + 1]
								new_seg = apply_word_replacements(seg, replacements)
								if new_seg != seg:
										edits.append((term_pos, end_block + 1, new_seg))

				i = close + 1

		if not edits:
				return False, 0

		edits.sort(key=lambda x: x[0], reverse=True)
		merged = []
		last_start = None
		for e in edits:
				if last_start is None or e[1] <= last_start:
						merged.append(e)
						last_start = e[0]

		new_text = text
		applied = 0
		for s, e, r in merged:
				new_text = new_text[:s] + r + new_text[e:]
				applied += 1

		if new_text != text:
				with open(path, "w", encoding="utf-8", newline="") as f:
						f.write(new_text)
				return True, applied

		return False, 0


def should_process(path: str):
		ap = os.path.abspath(path)
		if os.sep + "obj" + os.sep in ap or os.sep + "bin" + os.sep in ap:
				return False
		parent = os.path.dirname(ap)
		return parent in TARGET_DIRS and ap.endswith(".cs")


files_changed = 0
edits_applied = 0
for root, _, files in os.walk(ROOT):
		for file in files:
				path = os.path.join(root, file)
				if not should_process(path):
						continue
				changed, cnt = process_file(path)
				if changed:
						files_changed += 1
						edits_applied += cnt

print(f"FILES_CHANGED={files_changed}")
print(f"EDITS_APPLIED={edits_applied}")
