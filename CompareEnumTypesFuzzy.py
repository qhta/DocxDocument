#!/usr/bin/env python3
import csv
import re
from difflib import SequenceMatcher
from pathlib import Path

ROOT = Path(r"D:\OneDrive\VS\Projects\DocxDocument")
LEFT_DIR = ROOT / "DocumentModel.EnumTypes"
RIGHT_DIR = ROOT / "DocumentModel.Interop.Enums"
OUT_CSV = ROOT / "EnumTypes_vs_InteropEnums_Fuzzy.csv"
THRESHOLD = 0.70

NS_SCOPED = re.compile(r"(?m)^\s*namespace\s+([A-Za-z_][\w\.]*)\s*;")
NS_BLOCK = re.compile(r"(?m)^\s*namespace\s+([A-Za-z_][\w\.]*)\s*\{")
ENUM_RE = re.compile(r"(?m)^\s*(?:public|internal|private|protected)?\s*enum\s+([A-Za-z_][A-Za-z0-9_]*)\b")
PREFIX_RE = re.compile(r"^(wd|xl|mso|pp|ol|vis)", re.IGNORECASE)
HID_RE = re.compile(r"hid$", re.IGNORECASE)


def normalize(name: str) -> str:
    name = PREFIX_RE.sub("", name)
    name = HID_RE.sub("", name)
    return name.lower()


def read_enums(base_dir: Path) -> list[tuple[str, str]]:
    items: list[tuple[str, str]] = []
    for file_path in base_dir.rglob("*.cs"):
        text = file_path.read_text(encoding="utf-8", errors="ignore")
        ns_match = NS_SCOPED.search(text) or NS_BLOCK.search(text)
        ns = ns_match.group(1) if ns_match else ""
        for match in ENUM_RE.finditer(text):
            name = match.group(1)
            if name == "class":
                continue
            full_name = f"{ns}.{name}" if ns else name
            items.append((name, full_name))
    return items


def main() -> None:
    left = read_enums(LEFT_DIR)
    right = read_enums(RIGHT_DIR)

    rows: list[tuple[str, str, float]] = []

    for left_name, left_full in left:
        left_norm = normalize(left_name)
        best_full = ""
        best_score = 0.0

        for right_name, right_full in right:
            right_norm = normalize(right_name)
            score = SequenceMatcher(None, left_norm, right_norm).ratio()
            if score > best_score:
                best_score = score
                best_full = right_full

        if best_full and best_score >= THRESHOLD:
            rows.append((left_full, best_full, round(best_score, 4)))

    rows.sort(key=lambda row: (-row[2], row[0], row[1]))

    with OUT_CSV.open("w", newline="", encoding="utf-8") as f:
        writer = csv.writer(f)
        writer.writerow(["EnumTypesFullName", "InteropEnumsFullName"])
        writer.writerows((left_full, right_full) for left_full, right_full, _ in rows)

    print(f"Left enums: {len(left)}")
    print(f"Right enums: {len(right)}")
    print(f"Matched rows: {len(rows)}")
    print(f"CSV: {OUT_CSV}")


if __name__ == "__main__":
    main()
