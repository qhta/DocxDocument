namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
public enum WdLineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// A single solid line.
  /// </summary>
  Single = unchecked((int)1),
  /// <summary>
  /// Dots.
  /// </summary>
  Dot = unchecked((int)2),
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  DashSmallGap = unchecked((int)3),
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  DashLargeGap = unchecked((int)4),
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  DashDot = unchecked((int)5),
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  DashDotDot = unchecked((int)6),
  /// <summary>
  /// Double solid lines.
  /// </summary>
  Double = unchecked((int)7),
  /// <summary>
  /// Three solid thin lines. wdLineStyleThinThickSmallGap9 An internal single thin solid line surrounded by a
  /// single thick solid line with a small gap between them.
  /// [System.Runtime.InteropServices.Guid("54AFDECB-0EC4-397D-96AB-8E2A64FD7C3A")] public enum WdLineStyle ﾉ Expand
  /// table wdLineStyleThickThinSmallGap10 An internal single thick solid line surrounded by a single thin solid
  /// line with a small gap between them. wdLineStyleThinThickThinSmallGap11 An internal single thin solid line
  /// surrounded by a single thick solid line surrounded by a single thin solid line with a small gap between all
  /// lines.
  /// </summary>
  Triple = unchecked((int)8),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickSmallGap = unchecked((int)9),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinSmallGap = unchecked((int)10),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinSmallGap = unchecked((int)11),
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  ThinThickMedGap = unchecked((int)12),
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// wdLineStyleThinThickThinMedGap14 An internal single thin solid line surrounded by a single thick solid line
  /// surrounded by a single thin solid line with a medium gap between all lines. wdLineStyleThinThickLargeGap15 An
  /// internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// wdLineStyleThickThinLargeGap16 An internal single thick solid line surrounded by a single thin solid line with
  /// a large gap between them. wdLineStyleThinThickThinLargeGap17 An internal single thin solid line surrounded by
  /// a single thick solid line surrounded by a single thin solid line with a large gap between all lines.
  /// </summary>
  ThickThinMedGap = unchecked((int)13),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinMedGap = unchecked((int)14),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickLargeGap = unchecked((int)15),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinLargeGap = unchecked((int)16),
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinLargeGap = unchecked((int)17),
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  SingleWavy = unchecked((int)18),
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  DoubleWavy = unchecked((int)19),
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  DashDotStroked = unchecked((int)20),
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  Emboss3D = unchecked((int)21),
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  Engrave3D = unchecked((int)22),
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  Outset = unchecked((int)23),
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  Inset = unchecked((int)24)
}
