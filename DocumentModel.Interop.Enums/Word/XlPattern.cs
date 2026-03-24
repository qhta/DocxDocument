namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the interior pattern of a chart or interior object.
/// </summary>
public enum XlPattern
{
  /// <summary>
  /// Solid color.
  /// </summary>
  Solid = unchecked((int)1),
  /// <summary>
  /// Checkerboard.
  /// </summary>
  Checker = unchecked((int)9),
  /// <summary>
  /// 75% dark moiré.
  /// </summary>
  SemiGray75 = unchecked((int)10),
  /// <summary>
  /// Light horizontal lines. public enum XlPattern ﾉ Expand table
  /// </summary>
  LightHorizontal = unchecked((int)11),
  /// <summary>
  /// Light vertical bars.
  /// </summary>
  LightVertical = unchecked((int)12),
  /// <summary>
  /// Light diagonal lines running from the upper left to the lower right.
  /// </summary>
  LightDown = unchecked((int)13),
  /// <summary>
  /// Light diagonal lines running from the lower left to the upper right.
  /// </summary>
  LightUp = unchecked((int)14),
  /// <summary>
  /// Grid.
  /// </summary>
  Grid = unchecked((int)15),
  /// <summary>
  /// Criss-cross lines.
  /// </summary>
  CrissCross = unchecked((int)16),
  /// <summary>
  /// 16% gray.
  /// </summary>
  Gray16 = unchecked((int)17),
  /// <summary>
  /// 8% gray.
  /// </summary>
  Gray8 = unchecked((int)18),
  /// <summary>
  /// Linear gradient. xlPatternRectangularGradient4001 Rectangular gradient.
  /// </summary>
  LinearGradient = unchecked((int)4000),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  RectangularGradient = unchecked((int)4001),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Vertical = unchecked((int)-4166),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Up = unchecked((int)-4162),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  None = unchecked((int)-4142),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Horizontal = unchecked((int)-4128),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Gray75 = unchecked((int)-4126),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Gray50 = unchecked((int)-4125),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Gray25 = unchecked((int)-4124),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Down = unchecked((int)-4121),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  Automatic = unchecked((int)-4105)
}
