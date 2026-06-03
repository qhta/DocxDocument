import os
import re

ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
TARGET_DIRS = [
		os.path.join(ROOT, "BaseInterfaces"),
		os.path.join(ROOT, "CoreInterfaces"),
		os.path.join(ROOT, "WordInterfaces"),
]

prop_pattern = re.compile(
		r"^(?P<indent>\s*)public\s+(?P<type>[\w\.<>]+\??)\s+(?P<name>I[A-Za-z_][A-Za-z0-9_]*)\s*(?P<body>\{\s*(?:get;|set;|init;).*)$"
)

files_changed = 0
properties_renamed = 0

for target_dir in TARGET_DIRS:
		if not os.path.isdir(target_dir):
				continue

		for file_name in os.listdir(target_dir):
				if not file_name.endswith(".cs"):
						continue

				path = os.path.join(target_dir, file_name)
				with open(path, "r", encoding="utf-8") as f:
						lines = f.readlines()

				changed = False
				for i, line in enumerate(lines):
						m = prop_pattern.match(line)
						if not m:
								continue

						type_name = m.group("type")
						prop_name = m.group("name")
						type_base = type_name[:-1] if type_name.endswith("?") else type_name

						# Apply only when property name equals interface type name (ignoring nullable marker)
						if prop_name != type_base:
								continue

						# Type must look like an interface name
						if not type_base.startswith("I") or len(type_base) < 2 or not type_base[1].isupper():
								continue

						new_prop_name = prop_name[1:]
						if not new_prop_name:
								continue

						new_line = f"{m.group('indent')}public {type_name} {new_prop_name} {m.group('body')}\n"
						if new_line != line:
								lines[i] = new_line
								changed = True
								properties_renamed += 1

				if changed:
						with open(path, "w", encoding="utf-8", newline="") as f:
								f.writelines(lines)
						files_changed += 1

print(f"FILES_CHANGED={files_changed}")
print(f"PROPERTIES_RENAMED={properties_renamed}")
