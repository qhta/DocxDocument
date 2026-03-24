#!/usr/bin/env python3
import csv
import re
from difflib import SequenceMatcher
from pathlib import Path

ROOT = Path(r"D:\OneDrive\VS\Projects\DocxDocument")
INTEROP_DIR = ROOT / "DocumentModel.Interop.Enums"
ENUMTYPES_DIR = ROOT / "DocumentModel.EnumTypes"
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
    result: list[tuple[str, str]] = []
    for file_path in base_dir.rglob("*.cs"):
        text = file_path.read_text(encoding="utf-8", errors="ignore")
        ns_match = NS_SCOPED.search(text) or NS_BLOCK.search(text)
        ns = ns_match.group(1) if ns_match else ""
        for match in ENUM_RE.finditer(text):
            name = match.group(1)
            if name == "class":
                continue
            full_name = f"{ns}.{name}" if ns else name
            result.append((name, full_name))
    return result


def main() -> None:
    interop_enums = read_enums(INTEROP_DIR)
    enum_types = read_enums(ENUMTYPES_DIR)

    rows: list[tuple[str, str, float]] = []

    for enumtype_name, enumtype_full in enum_types:
    enumtype_norm = normalize(enumtype_name)

        best_full = ""
        best_score = 0.0

        for interop_name, interop_full in interop_enums:
        interop_norm = normalize(interop_name)
            score = SequenceMatcher(None, interop_norm, enumtype_norm).ratio()
            if score > best_score:
                best_score = score
                best_full = enumtype_full

        if best_full and best_score >= THRESHOLD:
            rows.append((interop_full, best_full, round(best_score, 4)))

    rows.sort(key=lambda row: (-row[2], row[0], row[1]))

    with OUT_CSV.open("w", newline="", encoding="utf-8") as f:
        writer = csv.writer(f)
        writer.writerow(["EnumTypesFullName","InteropEnumsFullName"])
        writer.writerows((enumtype_full, interop_full) for interop_full, enumtype_full, _ in rows)

    print(f"EnumTypes enums: {len(enum_types)}")
    print(f"Interop enums: {len(interop_enums)}")
    print(f"Matched rows: {len(rows)}")
    print(f"CSV: {OUT_CSV}")


if __name__ == "__main__":
    main()
