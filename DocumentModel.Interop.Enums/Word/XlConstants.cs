namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a miscellaneous constant in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlConstants))]
public enum XlConstants
{
  /// <summary>
  /// Summary row is displayed above the specified range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlAbove))]
  Above = 0,
  /// <summary>
  /// Display positive and negative error bars in the specified chart group or series.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlBoth))]
  Both = 1,
  /// <summary>
  /// Display error amounts as a fixed value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlFixedValue))]
  FixedValue = 1,
  /// <summary>
  /// Summary row is displayed below the specified range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlBelow))]
  Below = 1,
  /// <summary>
  /// General.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGeneral))]
  General = 1,
  /// <summary>
  /// Square.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlSquare))]
  Square = 1,
  /// <summary>
  /// Solid pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlSolid))]
  Solid = 1,
  /// <summary>
  /// Inside.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlInside))]
  Inside = 2,
  /// <summary>
  /// Maximum.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlMaximum))]
  Maximum = 2,
  /// <summary>
  /// Transparent fill.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlTransparent))]
  Transparent = 2,
  /// <summary>
  /// Display error amounts as a percentage.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlPercent))]
  Percent = 2,
  /// <summary>
  /// Corner.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCorner))]
  Corner = 2,
  /// <summary>
  /// Plus values.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlPlusValues))]
  PlusValues = 2,
  /// <summary>
  /// Two dimensional bar chart group or series.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlBar))]
  Bar = 2,
  /// <summary>
  /// Show value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlShowValue))]
  ShowValue = 2,
  /// <summary>
  /// Diamond pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlDiamond))]
  Diamond = 2,
  /// <summary>
  /// Single line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlSingle))]
  Single = 2,
  /// <summary>
  /// Opaque fill.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlOpaque))]
  Opaque = 3,
  /// <summary>
  /// Scale.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlScale))]
  Scale = 3,
  /// <summary>
  /// Outside.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlOutside))]
  Outside = 3,
  /// <summary>
  /// Columnar chart group or series.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlColumn))]
  Column = 3,
  /// <summary>
  /// Minus values.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlMinusValues))]
  MinusValues = 3,
  /// <summary>
  /// Triangle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlTriangle))]
  Triangle = 3,
  /// <summary>
  /// Show percent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlShowPercent))]
  ShowPercent = 3,
  /// <summary>
  /// Minimum.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlMinimum))]
  Minimum = 4,
  /// <summary>
  /// Next to axis.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlNextToAxis))]
  NextToAxis = 4,
  /// <summary>
  /// Show label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlShowLabel))]
  ShowLabel = 4,
  /// <summary>
  /// Display error amounts as a standard error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlStError))]
  StError = 4,
  /// <summary>
  /// Cross pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCross))]
  Cross = 4,
  /// <summary>
  /// Show label and percent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlShowLabelAndPercent))]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// Fill.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlFill))]
  Fill = 5,
  /// <summary>
  /// Star.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlStar))]
  Star = 5,
  /// <summary>
  /// Circle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCircle))]
  Circle = 8,
  /// <summary>
  /// Plus values.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlPlus))]
  Plus = 9,
  /// <summary>
  /// Checker pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlChecker))]
  Checker = 9,
  /// <summary>
  /// 75% semi-gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlSemiGray75))]
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal line pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLightHorizontal))]
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical line pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLightVertical))]
  LightVertical = 12,
  /// <summary>
  /// Light down line pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLightDown))]
  LightDown = 13,
  /// <summary>
  /// Light up line pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLightUp))]
  LightUp = 14,
  /// <summary>
  /// Grid pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGrid))]
  Grid = 15,
  /// <summary>
  /// Criss-cross pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCrissCross))]
  CrissCross = 16,
  /// <summary>
  /// 16% gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGray16))]
  Gray16 = 17,
  /// <summary>
  /// 8% gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGray8))]
  Gray8 = 18,
  /// <summary>
  /// Top.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlTop))]
  Top = -4160,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlRight))]
  Right = -4152,
  /// <summary>
  /// Do not display error bars in the specified chart group or series.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlNone))]
  None = -4142,
  /// <summary>
  /// Low.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLow))]
  Low = -4134,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlLeft))]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlJustify))]
  Justify = -4130,
  /// <summary>
  /// High.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlHigh))]
  High = -4127,
  /// <summary>
  /// 75% gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGray75))]
  Gray75 = -4126,
  /// <summary>
  /// 50% gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGray50))]
  Gray50 = -4125,
  /// <summary>
  /// 25% gray pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlGray25))]
  Gray25 = -4124,
  /// <summary>
  /// Distributed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlDistributed))]
  Distributed = -4117,
  /// <summary>
  /// Microsoft Word applies custom settings, such as a color or error amount, to the specified object. public enum
  /// Constants
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCustom))]
  Custom = -4114,
  /// <summary>
  /// Combination.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCombination))]
  Combination = -4111,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlCenter))]
  Center = -4108,
  /// <summary>
  /// Bottom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlBottom))]
  Bottom = -4107,
  /// <summary>
  /// Microsoft Word applies automatic settings, such as a color or page number, to the specified object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlAutomatic))]
  Automatic = -4105,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xl3DSurface))]
  ThreeDSurface = -4103,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xl3DBar))]
  ThreeDBar = -4099,
  /// <summary>
  /// Microsoft Word applies default or automatic formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlConstants.xlDefaultAutoFormat))]
  DefaultAutoFormat = -1
}
