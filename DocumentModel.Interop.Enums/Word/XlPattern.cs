namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the interior pattern of a chart or interior object.
/// </summary>
public enum XlPattern
{
  /// <summary>
  /// Solid color.
  /// </summary>
  xlPatternSolid = unchecked((int)1),
  /// <summary>
  /// Checkerboard.
  /// </summary>
  xlPatternChecker = unchecked((int)9),
  /// <summary>
  /// 75% dark moiré.
  /// </summary>
  xlPatternSemiGray75 = unchecked((int)10),
  /// <summary>
  /// Light horizontal lines. public enum XlPattern ﾉ Expand table
  /// </summary>
  xlPatternLightHorizontal = unchecked((int)11),
  /// <summary>
  /// Light vertical bars.
  /// </summary>
  xlPatternLightVertical = unchecked((int)12),
  /// <summary>
  /// Light diagonal lines running from the upper left to the lower right.
  /// </summary>
  xlPatternLightDown = unchecked((int)13),
  /// <summary>
  /// Light diagonal lines running from the lower left to the upper right.
  /// </summary>
  xlPatternLightUp = unchecked((int)14),
  /// <summary>
  /// Grid.
  /// </summary>
  xlPatternGrid = unchecked((int)15),
  /// <summary>
  /// Criss-cross lines.
  /// </summary>
  xlPatternCrissCross = unchecked((int)16),
  /// <summary>
  /// 16% gray.
  /// </summary>
  xlPatternGray16 = unchecked((int)17),
  /// <summary>
  /// 8% gray.
  /// </summary>
  xlPatternGray8 = unchecked((int)18),
  /// <summary>
  /// Linear gradient. xlPatternRectangularGradient4001 Rectangular gradient.
  /// </summary>
  xlPatternLinearGradient = unchecked((int)4000),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternRectangularGradient = unchecked((int)4001),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternVertical = unchecked((int)-4166),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternUp = unchecked((int)-4162),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternNone = unchecked((int)-4142),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternHorizontal = unchecked((int)-4128),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternGray75 = unchecked((int)-4126),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternGray50 = unchecked((int)-4125),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternGray25 = unchecked((int)-4124),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternDown = unchecked((int)-4121),
  /// <summary>
  /// Specifies the interior pattern of a chart or interior object.
  /// </summary>
  xlPatternAutomatic = unchecked((int)-4105)
}
