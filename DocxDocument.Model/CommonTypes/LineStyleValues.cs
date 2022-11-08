namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum LineStyle
{
  None,
  Single,
  Dot,
  DashSmallGap,
  DashLargeGap,
  DashDot,
  DashDotDot,
  Double,
  Triple,
  ThinThickSmallGap,
  ThickThinSmallGap,
  ThinThickThinSmallGap,
  ThinThickMedGap,
  ThickThinMedGap,
  ThinThickThinMedGap,
  ThinThickLargeGap,
  ThickThinLargeGap,
  ThinThickThinLargeGap,
  SingleWavy,
  DoubleWavy,
  DashDotStroked,
  Emboss3D,
  Engrave3D,
  Outset,
  Inset,
}