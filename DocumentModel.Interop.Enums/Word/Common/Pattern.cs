namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the interior pattern of a chart or interior object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpattern?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlPattern")]
public enum Pattern
{
  /// <summary>
  /// Solid color.
  /// </summary>
  [InteropEnumValue("xlPatternSolid")]
  Solid = 1,
  /// <summary>
  /// Checkerboard.
  /// </summary>
  [InteropEnumValue("xlPatternChecker")]
  Checker = 9,
  /// <summary>
  /// 75% dark moirĂ©.
  /// </summary>
  [InteropEnumValue("xlPatternSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal lines. public enum Pattern
  /// </summary>
  [InteropEnumValue("xlPatternLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical bars.
  /// </summary>
  [InteropEnumValue("xlPatternLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// Light diagonal lines running from the upper left to the lower right.
  /// </summary>
  [InteropEnumValue("xlPatternLightDown")]
  LightDown = 13,
  /// <summary>
  /// Light diagonal lines running from the lower left to the upper right.
  /// </summary>
  [InteropEnumValue("xlPatternLightUp")]
  LightUp = 14,
  /// <summary>
  /// Grid.
  /// </summary>
  [InteropEnumValue("xlPatternGrid")]
  Grid = 15,
  /// <summary>
  /// Criss-cross lines.
  /// </summary>
  [InteropEnumValue("xlPatternCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 16% gray.
  /// </summary>
  [InteropEnumValue("xlPatternGray16")]
  Gray16 = 17,
  /// <summary>
  /// 8% gray.
  /// </summary>
  [InteropEnumValue("xlPatternGray8")]
  Gray8 = 18,
  /// <summary>
  /// Linear gradient.
  /// </summary>
  [InteropEnumValue("xlPatternLinearGradient")]
  LinearGradient = 4000,
  /// <summary>
  /// Rectangular gradient.
  /// </summary>
  [InteropEnumValue("xlPatternRectangularGradient")]
  RectangularGradient = 4001,
  /// <summary>
  /// Dark vertical bars.
  /// </summary>
  [InteropEnumValue("xlPatternVertical")]
  Vertical = -4166,
  /// <summary>
  /// Dark diagonal lines running from the lower left to the upper right.
  /// </summary>
  [InteropEnumValue("xlPatternUp")]
  Up = -4162,
  /// <summary>
  /// No pattern.
  /// </summary>
  [InteropEnumValue("xlPatternNone")]
  None = -4142,
  /// <summary>
  /// Dark horizontal lines.
  /// </summary>
  [InteropEnumValue("xlPatternHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// 75% gray.
  /// </summary>
  [InteropEnumValue("xlPatternGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 50% gray.
  /// </summary>
  [InteropEnumValue("xlPatternGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 25% gray.
  /// </summary>
  [InteropEnumValue("xlPatternGray25")]
  Gray25 = -4124,
  /// <summary>
  /// Dark diagonal lines running from the upper left to the lower right.
  /// </summary>
  [InteropEnumValue("xlPatternDown")]
  Down = -4121,
  /// <summary>
  /// Word controls the pattern.
  /// </summary>
  [InteropEnumValue("xlPatternAutomatic")]
  Automatic = -4105
}

