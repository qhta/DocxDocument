namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a miscellaneous constant in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlConstants")]
public enum XlConstants
{
  /// <summary>
  /// Summary row is displayed above the specified range.
  /// </summary>
  [InteropEnumValue("xlAbove")]
  Above = 0,
  /// <summary>
  /// Display positive and negative error bars in the specified chart group or series.
  /// </summary>
  [InteropEnumValue("xlBoth")]
  Both = 1,
  /// <summary>
  /// Display error amounts as a fixed value.
  /// </summary>
  [InteropEnumValue("xlFixedValue")]
  FixedValue = 1,
  /// <summary>
  /// Summary row is displayed below the specified range.
  /// </summary>
  [InteropEnumValue("xlBelow")]
  Below = 1,
  /// <summary>
  /// General.
  /// </summary>
  [InteropEnumValue("xlGeneral")]
  General = 1,
  /// <summary>
  /// Square.
  /// </summary>
  [InteropEnumValue("xlSquare")]
  Square = 1,
  /// <summary>
  /// Solid pattern.
  /// </summary>
  [InteropEnumValue("xlSolid")]
  Solid = 1,
  /// <summary>
  /// Inside.
  /// </summary>
  [InteropEnumValue("xlInside")]
  Inside = 2,
  /// <summary>
  /// Maximum.
  /// </summary>
  [InteropEnumValue("xlMaximum")]
  Maximum = 2,
  /// <summary>
  /// Transparent fill.
  /// </summary>
  [InteropEnumValue("xlTransparent")]
  Transparent = 2,
  /// <summary>
  /// Display error amounts as a percentage.
  /// </summary>
  [InteropEnumValue("xlPercent")]
  Percent = 2,
  /// <summary>
  /// Corner.
  /// </summary>
  [InteropEnumValue("xlCorner")]
  Corner = 2,
  /// <summary>
  /// Plus values.
  /// </summary>
  [InteropEnumValue("xlPlusValues")]
  PlusValues = 2,
  /// <summary>
  /// Two dimensional bar chart group or series.
  /// </summary>
  [InteropEnumValue("xlBar")]
  Bar = 2,
  /// <summary>
  /// Show value.
  /// </summary>
  [InteropEnumValue("xlShowValue")]
  ShowValue = 2,
  /// <summary>
  /// Diamond pattern.
  /// </summary>
  [InteropEnumValue("xlDiamond")]
  Diamond = 2,
  /// <summary>
  /// Single line.
  /// </summary>
  [InteropEnumValue("xlSingle")]
  Single = 2,
  /// <summary>
  /// Opaque fill.
  /// </summary>
  [InteropEnumValue("xlOpaque")]
  Opaque = 3,
  /// <summary>
  /// Scale.
  /// </summary>
  [InteropEnumValue("xlScale")]
  Scale = 3,
  /// <summary>
  /// Outside.
  /// </summary>
  [InteropEnumValue("xlOutside")]
  Outside = 3,
  /// <summary>
  /// Columnar chart group or series.
  /// </summary>
  [InteropEnumValue("xlColumn")]
  Column = 3,
  /// <summary>
  /// Minus values.
  /// </summary>
  [InteropEnumValue("xlMinusValues")]
  MinusValues = 3,
  /// <summary>
  /// Triangle.
  /// </summary>
  [InteropEnumValue("xlTriangle")]
  Triangle = 3,
  /// <summary>
  /// Show percent.
  /// </summary>
  [InteropEnumValue("xlShowPercent")]
  ShowPercent = 3,
  /// <summary>
  /// Minimum.
  /// </summary>
  [InteropEnumValue("xlMinimum")]
  Minimum = 4,
  /// <summary>
  /// Next to axis.
  /// </summary>
  [InteropEnumValue("xlNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// Show label.
  /// </summary>
  [InteropEnumValue("xlShowLabel")]
  ShowLabel = 4,
  /// <summary>
  /// Display error amounts as a standard error.
  /// </summary>
  [InteropEnumValue("xlStError")]
  StError = 4,
  /// <summary>
  /// Cross pattern.
  /// </summary>
  [InteropEnumValue("xlCross")]
  Cross = 4,
  /// <summary>
  /// Show label and percent.
  /// </summary>
  [InteropEnumValue("xlShowLabelAndPercent")]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// Fill.
  /// </summary>
  [InteropEnumValue("xlFill")]
  Fill = 5,
  /// <summary>
  /// Star.
  /// </summary>
  [InteropEnumValue("xlStar")]
  Star = 5,
  /// <summary>
  /// Circle.
  /// </summary>
  [InteropEnumValue("xlCircle")]
  Circle = 8,
  /// <summary>
  /// Plus values.
  /// </summary>
  [InteropEnumValue("xlPlus")]
  Plus = 9,
  /// <summary>
  /// Checker pattern.
  /// </summary>
  [InteropEnumValue("xlChecker")]
  Checker = 9,
  /// <summary>
  /// 75% semi-gray pattern.
  /// </summary>
  [InteropEnumValue("xlSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal line pattern.
  /// </summary>
  [InteropEnumValue("xlLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical line pattern.
  /// </summary>
  [InteropEnumValue("xlLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// Light down line pattern.
  /// </summary>
  [InteropEnumValue("xlLightDown")]
  LightDown = 13,
  /// <summary>
  /// Light up line pattern.
  /// </summary>
  [InteropEnumValue("xlLightUp")]
  LightUp = 14,
  /// <summary>
  /// Grid pattern.
  /// </summary>
  [InteropEnumValue("xlGrid")]
  Grid = 15,
  /// <summary>
  /// Criss-cross pattern.
  /// </summary>
  [InteropEnumValue("xlCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 16% gray pattern.
  /// </summary>
  [InteropEnumValue("xlGray16")]
  Gray16 = 17,
  /// <summary>
  /// 8% gray pattern.
  /// </summary>
  [InteropEnumValue("xlGray8")]
  Gray8 = 18,
  /// <summary>
  /// Top.
  /// </summary>
  [InteropEnumValue("xlTop")]
  Top = -4160,
  /// <summary>
  /// Right.
  /// </summary>
  [InteropEnumValue("xlRight")]
  Right = -4152,
  /// <summary>
  /// Do not display error bars in the specified chart group or series.
  /// </summary>
  [InteropEnumValue("xlNone")]
  None = -4142,
  /// <summary>
  /// Low.
  /// </summary>
  [InteropEnumValue("xlLow")]
  Low = -4134,
  /// <summary>
  /// Left.
  /// </summary>
  [InteropEnumValue("xlLeft")]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [InteropEnumValue("xlJustify")]
  Justify = -4130,
  /// <summary>
  /// High.
  /// </summary>
  [InteropEnumValue("xlHigh")]
  High = -4127,
  /// <summary>
  /// 75% gray pattern.
  /// </summary>
  [InteropEnumValue("xlGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 50% gray pattern.
  /// </summary>
  [InteropEnumValue("xlGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 25% gray pattern.
  /// </summary>
  [InteropEnumValue("xlGray25")]
  Gray25 = -4124,
  /// <summary>
  /// Distributed.
  /// </summary>
  [InteropEnumValue("xlDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Microsoft Word applies custom settings, such as a color or error amount, to the specified object. public enum
  /// Constants
  /// </summary>
  [InteropEnumValue("xlCustom")]
  Custom = -4114,
  /// <summary>
  /// Combination.
  /// </summary>
  [InteropEnumValue("xlCombination")]
  Combination = -4111,
  /// <summary>
  /// Center.
  /// </summary>
  [InteropEnumValue("xlCenter")]
  Center = -4108,
  /// <summary>
  /// Bottom.
  /// </summary>
  [InteropEnumValue("xlBottom")]
  Bottom = -4107,
  /// <summary>
  /// Microsoft Word applies automatic settings, such as a color or page number, to the specified object.
  /// </summary>
  [InteropEnumValue("xlAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [InteropEnumValue("xl3DSurface")]
  ThreeDSurface = -4103,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [InteropEnumValue("xl3DBar")]
  ThreeDBar = -4099,
  /// <summary>
  /// Microsoft Word applies default or automatic formatting.
  /// </summary>
  [InteropEnumValue("xlDefaultAutoFormat")]
  DefaultAutoFormat = -1
}
