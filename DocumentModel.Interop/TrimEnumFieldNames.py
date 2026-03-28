#!/usr/bin/env python3
import argparse
import os
import re
import sys
from pathlib import Path


def find_first_enum(text: str) -> re.Match[str] | None:
    pattern = re.compile(
        r"(?P<prefix>\b(?:public|private|internal|protected|static|new|\s)+\benum\s+\w+(?:\s*:\s*[\w\.]+)?\s*\{)(?P<body>.*?)(?P<suffix>\})",
        re.DOTALL,
    )
    match = pattern.search(text)
    if match:
        return match

    fallback = re.compile(
        r"(?P<prefix>\benum\s+\w+(?:\s*:\s*[\w\.]+)?\s*\{)(?P<body>.*?)(?P<suffix>\})",
        re.DOTALL,
    )
    return fallback.search(text)


def get_common_prefix(names: list[str]) -> str:
    if not names:
        return ""
    prefix = os.path.commonprefix(names)
    if not prefix:
        return ""
    if any(name == prefix for name in names):
        return ""
    return prefix


def trim_enum_fields(body: str, prefix: str) -> tuple[str, int]:
    if not prefix:
        return body, 0

    member_pattern = re.compile(
        r"^(?P<indent>\s*)(?P<name>@?[A-Za-z_]\w*)(?P<rest>\s*(?:=\s*[^,\n]+)?\s*,?\s*(?://.*)?)$",
        re.MULTILINE,
    )

    replaced = 0

    def repl(match: re.Match[str]) -> str:
        nonlocal replaced
        name = match.group("name")
        if not name.startswith(prefix):
            return match.group(0)
        trimmed = name[len(prefix):]
        if not trimmed:
            return match.group(0)
        replaced += 1
        return f"{match.group('indent')}{trimmed}{match.group('rest')}"

    new_body = member_pattern.sub(repl, body)
    return new_body, replaced


def extract_member_names(body: str) -> list[str]:
    member_pattern = re.compile(
        r"^(?:\s*)(?P<name>@?[A-Za-z_]\w*)(?:\s*(?:=\s*[^,\n]+)?\s*,?\s*(?://.*)?)$",
        re.MULTILINE,
    )
    return [m.group("name") for m in member_pattern.finditer(body)]


def process_file(path: Path, write_changes: bool) -> int:
    if not path.exists():
        print(f"File not found: {path}", file=sys.stderr)
        return 1

    text = path.read_text(encoding="utf-8")
    enum_match = find_first_enum(text)
    if enum_match is None:
        print("No enum declaration found.", file=sys.stderr)
        return 1

    body = enum_match.group("body")
    names = extract_member_names(body)

    if not names:
        print("No enum fields found.", file=sys.stderr)
        return 1

    prefix = get_common_prefix(names)
    if not prefix:
        print("No common prefix found. No changes made.")
        return 0

    new_body, count = trim_enum_fields(body, prefix)
    if count == 0:
        print("No fields changed.")
        return 0

    new_text = f"{text[:enum_match.start('body')]}{new_body}{text[enum_match.end('body'):] }"

    if write_changes:
        path.write_text(new_text, encoding="utf-8")
        print(f"Removed common prefix '{prefix}' from {count} enum fields in: {path}")
    else:
        print(f"Detected common prefix '{prefix}' in {count} enum fields.")

    return 0


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Trim common prefix from enum field names in a C# file."
    )
    parser.add_argument("file", help="Path to the C# file containing an enum declaration")
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Detect prefix and show result without modifying file",
    )

    args = parser.parse_args()
    return process_file(Path(args.file), write_changes=not args.dry_run)


if __name__ == "__main__":
    raise SystemExit(main())
