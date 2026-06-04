namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the interior pattern of a chart or interior object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpattern?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlPattern")]
public enum XlPattern
{
  /// <summary>
  /// Solid color.
  /// </summary>
  [WordInteropEnumValue("xlPatternSolid")]
  Solid = 1,
  /// <summary>
  /// Checkerboard.
  /// </summary>
  [WordInteropEnumValue("xlPatternChecker")]
  Checker = 9,
  /// <summary>
  /// 75% dark moirĂ©.
  /// </summary>
  [WordInteropEnumValue("xlPatternSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal lines. public enum XlPattern
  /// </summary>
  [WordInteropEnumValue("xlPatternLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical bars.
  /// </summary>
  [WordInteropEnumValue("xlPatternLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// Light diagonal lines running from the upper left to the lower right.
  /// </summary>
  [WordInteropEnumValue("xlPatternLightDown")]
  LightDown = 13,
  /// <summary>
  /// Light diagonal lines running from the lower left to the upper right.
  /// </summary>
  [WordInteropEnumValue("xlPatternLightUp")]
  LightUp = 14,
  /// <summary>
  /// Grid.
  /// </summary>
  [WordInteropEnumValue("xlPatternGrid")]
  Grid = 15,
  /// <summary>
  /// Criss-cross lines.
  /// </summary>
  [WordInteropEnumValue("xlPatternCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 16% gray.
  /// </summary>
  [WordInteropEnumValue("xlPatternGray16")]
  Gray16 = 17,
  /// <summary>
  /// 8% gray.
  /// </summary>
  [WordInteropEnumValue("xlPatternGray8")]
  Gray8 = 18,
  /// <summary>
  /// Linear gradient.
  /// </summary>
  [WordInteropEnumValue("xlPatternLinearGradient")]
  LinearGradient = 4000,
  /// <summary>
  /// Rectangular gradient.
  /// </summary>
  [WordInteropEnumValue("xlPatternRectangularGradient")]
  RectangularGradient = 4001,
  /// <summary>
  /// Dark vertical bars.
  /// </summary>
  [WordInteropEnumValue("xlPatternVertical")]
  Vertical = -4166,
  /// <summary>
  /// Dark diagonal lines running from the lower left to the upper right.
  /// </summary>
  [WordInteropEnumValue("xlPatternUp")]
  Up = -4162,
  /// <summary>
  /// No pattern.
  /// </summary>
  [WordInteropEnumValue("xlPatternNone")]
  None = -4142,
  /// <summary>
  /// Dark horizontal lines.
  /// </summary>
  [WordInteropEnumValue("xlPatternHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// 75% gray.
  /// </summary>
  [WordInteropEnumValue("xlPatternGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 50% gray.
  /// </summary>
  [WordInteropEnumValue("xlPatternGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 25% gray.
  /// </summary>
  [WordInteropEnumValue("xlPatternGray25")]
  Gray25 = -4124,
  /// <summary>
  /// Dark diagonal lines running from the upper left to the lower right.
  /// </summary>
  [WordInteropEnumValue("xlPatternDown")]
  Down = -4121,
  /// <summary>
  /// Word controls the pattern.
  /// </summary>
  [WordInteropEnumValue("xlPatternAutomatic")]
  Automatic = -4105
}
