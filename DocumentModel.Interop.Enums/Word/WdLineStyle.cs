namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
public enum WdLineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  Double = 7,
  /// <summary>
  /// Three solid thin lines. wdLineStyleThinThickSmallGap9 An internal single thin solid line surrounded by a
  /// single thick solid line with a small gap between them.
  /// [System.Runtime.InteropServices.Guid("54AFDECB-0EC4-397D-96AB-8E2A64FD7C3A")] public enum WdLineStyle ﾉ Expand
  /// table wdLineStyleThickThinSmallGap10 An internal single thick solid line surrounded by a single thin solid
  /// line with a small gap between them. wdLineStyleThinThickThinSmallGap11 An internal single thin solid line
  /// surrounded by a single thick solid line surrounded by a single thin solid line with a small gap between all
  /// lines.
  /// </summary>
  Triple = 8,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickSmallGap = 9,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinSmallGap = 10,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// wdLineStyleThinThickThinMedGap14 An internal single thin solid line surrounded by a single thick solid line
  /// surrounded by a single thin solid line with a medium gap between all lines. wdLineStyleThinThickLargeGap15 An
  /// internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// wdLineStyleThickThinLargeGap16 An internal single thick solid line surrounded by a single thin solid line with
  /// a large gap between them. wdLineStyleThinThickThinLargeGap17 An internal single thin solid line surrounded by
  /// a single thick solid line surrounded by a single thin solid line with a large gap between all lines.
  /// </summary>
  ThickThinMedGap = 13,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinMedGap = 14,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickLargeGap = 15,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinLargeGap = 16,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  Inset = 24
}
