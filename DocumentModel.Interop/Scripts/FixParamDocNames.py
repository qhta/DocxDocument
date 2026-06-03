import os
import re

ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
TARGET_DIRS = {
		os.path.join(ROOT, "BaseClasses"),
		os.path.join(ROOT, "BaseInterfaces"),
		os.path.join(ROOT, "CoreClasses"),
		os.path.join(ROOT, "CoreInterfaces"),
		os.path.join(ROOT, "WordClasses"),
		os.path.join(ROOT, "WordInterfaces"),
}
DECL_KEYWORDS = ("public", "private", "protected", "internal")
CONTROL_WORDS = {"if", "for", "foreach", "while", "switch", "catch", "lock", "using", "return", "new", "nameof", "sizeof", "typeof"}
RENAME_MAP = {
		"object": "obj",
		"string": "text",
		"namespace": "xmlNamespace",
		"event": "eventArgs",
		"params": "parameters",
}


def is_ident_char(c: str) -> bool:
		return c.isalnum() or c in {"_", "@"}


def find_matching(text: str, start: int, open_ch: str, close_ch: str) -> int:
		depth = 0
		for i in range(start, len(text)):
				ch = text[i]
				if ch == open_ch:
						depth += 1
				elif ch == close_ch:
						depth -= 1
						if depth == 0:
								return i
		return -1


def split_top_level(s: str, sep: str = ","):
		parts = []
		start = 0
		a = b = c = 0
		for i, ch in enumerate(s):
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


def get_word_before_paren(text: str, paren_index: int) -> str:
		i = paren_index - 1
		while i >= 0 and text[i].isspace():
				i -= 1
		end = i + 1
		while i >= 0 and is_ident_char(text[i]):
				i -= 1
		return text[i + 1:end]


def parse_param_name(seg: str):
		left, _ = split_default(seg)
		m = re.search(r"(@?[A-Za-z_][A-Za-z0-9_]*)\s*$", left)
		if not m:
				return None
		return m.group(1)


def extract_param_names(signature: str):
		parts = split_top_level(signature, ",")
		names = []
		for p in parts:
				n = parse_param_name(p)
				if n:
						names.append(n)
		return names


def normalize(n: str) -> str:
		return n[1:] if n.startswith("@") else n


def should_process(path: str) -> bool:
		ap = os.path.abspath(path)
		if os.sep + "obj" + os.sep in ap or os.sep + "bin" + os.sep in ap:
				return False
		return os.path.dirname(ap) in TARGET_DIRS and ap.endswith(".cs")


def process_file(path: str):
		with open(path, "r", encoding="utf-8") as f:
				text = f.read()
		lines = text.splitlines(keepends=True)

		line_starts = []
		offset = 0
		for ln in lines:
				line_starts.append(offset)
				offset += len(ln)

		def line_of_pos(pos: int) -> int:
				lo, hi = 0, len(line_starts) - 1
				while lo <= hi:
						mid = (lo + hi) // 2
						if line_starts[mid] <= pos:
								lo = mid + 1
						else:
								hi = mid - 1
				return hi

		edits = []
		i = 0
		n = len(text)

		while i < n:
				p = text.find("(", i)
				if p == -1:
						break

				start_line = line_of_pos(p)
				line_text = lines[start_line]
				prefix = line_text[: max(0, p - line_starts[start_line])]
				if not any(k in prefix for k in DECL_KEYWORDS):
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

				param_sig = text[p + 1:close]
				params = extract_param_names(param_sig)
				if not params:
						i = close + 1
						continue

				params_norm = [normalize(x) for x in params]

				comment_end = start_line - 1
				while comment_end >= 0 and lines[comment_end].strip() == "":
						comment_end -= 1
				if comment_end < 0 or not lines[comment_end].lstrip().startswith("///"):
						i = close + 1
						continue

				comment_start = comment_end
				while comment_start >= 0 and lines[comment_start].lstrip().startswith("///"):
						comment_start -= 1
				comment_start += 1

				param_line_idxs = []
				for li in range(comment_start, comment_end + 1):
						if "<param name=" in lines[li]:
								param_line_idxs.append(li)

				if not param_line_idxs:
						i = close + 1
						continue

				used = set()
				for idx_pos, li in enumerate(param_line_idxs):
						line = lines[li]
						m = re.search(r'(<param\s+name=")(.*?)(">)', line)
						if not m:
								continue
						old_name = m.group(2)
						old_norm = normalize(old_name)

						new_name = None
						# exact match
						for j, pn in enumerate(params_norm):
								if pn == old_norm and j not in used:
										new_name = params_norm[j]
										used.add(j)
										break
						# case-insensitive match
						if new_name is None:
								for j, pn in enumerate(params_norm):
										if pn.lower() == old_norm.lower() and j not in used:
												new_name = params_norm[j]
												used.add(j)
												break
						# keyword rename map
						if new_name is None:
								mapped = RENAME_MAP.get(old_norm.lower())
								if mapped:
										for j, pn in enumerate(params_norm):
												if pn == mapped and j not in used:
														new_name = pn
														used.add(j)
														break
						# order fallback
						if new_name is None and idx_pos < len(params_norm):
								cand = params_norm[idx_pos]
								j = idx_pos
								if j not in used:
										new_name = cand
										used.add(j)

						if new_name and new_name != old_name:
								new_line = line[:m.start(2)] + new_name + line[m.end(2):]
								edits.append((li, new_line))

				i = close + 1

		if not edits:
				return False, 0

		changed = 0
		for li, new_line in edits:
				if lines[li] != new_line:
						lines[li] = new_line
						changed += 1

		if changed:
				with open(path, "w", encoding="utf-8", newline="") as f:
						f.write("".join(lines))
				return True, changed
		return False, 0


files_changed = 0
line_edits = 0
for root, _, files in os.walk(ROOT):
		for fn in files:
				p = os.path.join(root, fn)
				if not should_process(p):
						continue
				c, e = process_file(p)
				if c:
						files_changed += 1
						line_edits += e

print(f"FILES_CHANGED={files_changed}")
print(f"PARAM_DOC_LINES_UPDATED={line_edits}")
