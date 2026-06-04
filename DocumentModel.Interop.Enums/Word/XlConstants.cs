namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a miscellaneous constant in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlConstants")]
public enum XlConstants
{
  /// <summary>
  /// Summary row is displayed above the specified range.
  /// </summary>
  [WordInteropEnumValue("xlAbove")]
  Above = 0,
  /// <summary>
  /// Display positive and negative error bars in the specified chart group or series.
  /// </summary>
  [WordInteropEnumValue("xlBoth")]
  Both = 1,
  /// <summary>
  /// Display error amounts as a fixed value.
  /// </summary>
  [WordInteropEnumValue("xlFixedValue")]
  FixedValue = 1,
  /// <summary>
  /// Summary row is displayed below the specified range.
  /// </summary>
  [WordInteropEnumValue("xlBelow")]
  Below = 1,
  /// <summary>
  /// General.
  /// </summary>
  [WordInteropEnumValue("xlGeneral")]
  General = 1,
  /// <summary>
  /// Square.
  /// </summary>
  [WordInteropEnumValue("xlSquare")]
  Square = 1,
  /// <summary>
  /// Solid pattern.
  /// </summary>
  [WordInteropEnumValue("xlSolid")]
  Solid = 1,
  /// <summary>
  /// Inside.
  /// </summary>
  [WordInteropEnumValue("xlInside")]
  Inside = 2,
  /// <summary>
  /// Maximum.
  /// </summary>
  [WordInteropEnumValue("xlMaximum")]
  Maximum = 2,
  /// <summary>
  /// Transparent fill.
  /// </summary>
  [WordInteropEnumValue("xlTransparent")]
  Transparent = 2,
  /// <summary>
  /// Display error amounts as a percentage.
  /// </summary>
  [WordInteropEnumValue("xlPercent")]
  Percent = 2,
  /// <summary>
  /// Corner.
  /// </summary>
  [WordInteropEnumValue("xlCorner")]
  Corner = 2,
  /// <summary>
  /// Plus values.
  /// </summary>
  [WordInteropEnumValue("xlPlusValues")]
  PlusValues = 2,
  /// <summary>
  /// Two dimensional bar chart group or series.
  /// </summary>
  [WordInteropEnumValue("xlBar")]
  Bar = 2,
  /// <summary>
  /// Show value.
  /// </summary>
  [WordInteropEnumValue("xlShowValue")]
  ShowValue = 2,
  /// <summary>
  /// Diamond pattern.
  /// </summary>
  [WordInteropEnumValue("xlDiamond")]
  Diamond = 2,
  /// <summary>
  /// Single line.
  /// </summary>
  [WordInteropEnumValue("xlSingle")]
  Single = 2,
  /// <summary>
  /// Opaque fill.
  /// </summary>
  [WordInteropEnumValue("xlOpaque")]
  Opaque = 3,
  /// <summary>
  /// Scale.
  /// </summary>
  [WordInteropEnumValue("xlScale")]
  Scale = 3,
  /// <summary>
  /// Outside.
  /// </summary>
  [WordInteropEnumValue("xlOutside")]
  Outside = 3,
  /// <summary>
  /// Columnar chart group or series.
  /// </summary>
  [WordInteropEnumValue("xlColumn")]
  Column = 3,
  /// <summary>
  /// Minus values.
  /// </summary>
  [WordInteropEnumValue("xlMinusValues")]
  MinusValues = 3,
  /// <summary>
  /// Triangle.
  /// </summary>
  [WordInteropEnumValue("xlTriangle")]
  Triangle = 3,
  /// <summary>
  /// Show percent.
  /// </summary>
  [WordInteropEnumValue("xlShowPercent")]
  ShowPercent = 3,
  /// <summary>
  /// Minimum.
  /// </summary>
  [WordInteropEnumValue("xlMinimum")]
  Minimum = 4,
  /// <summary>
  /// Next to axis.
  /// </summary>
  [WordInteropEnumValue("xlNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// Show label.
  /// </summary>
  [WordInteropEnumValue("xlShowLabel")]
  ShowLabel = 4,
  /// <summary>
  /// Display error amounts as a standard error.
  /// </summary>
  [WordInteropEnumValue("xlStError")]
  StError = 4,
  /// <summary>
  /// Cross pattern.
  /// </summary>
  [WordInteropEnumValue("xlCross")]
  Cross = 4,
  /// <summary>
  /// Show label and percent.
  /// </summary>
  [WordInteropEnumValue("xlShowLabelAndPercent")]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// Fill.
  /// </summary>
  [WordInteropEnumValue("xlFill")]
  Fill = 5,
  /// <summary>
  /// Star.
  /// </summary>
  [WordInteropEnumValue("xlStar")]
  Star = 5,
  /// <summary>
  /// Circle.
  /// </summary>
  [WordInteropEnumValue("xlCircle")]
  Circle = 8,
  /// <summary>
  /// Plus values.
  /// </summary>
  [WordInteropEnumValue("xlPlus")]
  Plus = 9,
  /// <summary>
  /// Checker pattern.
  /// </summary>
  [WordInteropEnumValue("xlChecker")]
  Checker = 9,
  /// <summary>
  /// 75% semi-gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal line pattern.
  /// </summary>
  [WordInteropEnumValue("xlLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical line pattern.
  /// </summary>
  [WordInteropEnumValue("xlLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// Light down line pattern.
  /// </summary>
  [WordInteropEnumValue("xlLightDown")]
  LightDown = 13,
  /// <summary>
  /// Light up line pattern.
  /// </summary>
  [WordInteropEnumValue("xlLightUp")]
  LightUp = 14,
  /// <summary>
  /// Grid pattern.
  /// </summary>
  [WordInteropEnumValue("xlGrid")]
  Grid = 15,
  /// <summary>
  /// Criss-cross pattern.
  /// </summary>
  [WordInteropEnumValue("xlCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 16% gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlGray16")]
  Gray16 = 17,
  /// <summary>
  /// 8% gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlGray8")]
  Gray8 = 18,
  /// <summary>
  /// Top.
  /// </summary>
  [WordInteropEnumValue("xlTop")]
  Top = -4160,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue("xlRight")]
  Right = -4152,
  /// <summary>
  /// Do not display error bars in the specified chart group or series.
  /// </summary>
  [WordInteropEnumValue("xlNone")]
  None = -4142,
  /// <summary>
  /// Low.
  /// </summary>
  [WordInteropEnumValue("xlLow")]
  Low = -4134,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue("xlLeft")]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [WordInteropEnumValue("xlJustify")]
  Justify = -4130,
  /// <summary>
  /// High.
  /// </summary>
  [WordInteropEnumValue("xlHigh")]
  High = -4127,
  /// <summary>
  /// 75% gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 50% gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 25% gray pattern.
  /// </summary>
  [WordInteropEnumValue("xlGray25")]
  Gray25 = -4124,
  /// <summary>
  /// Distributed.
  /// </summary>
  [WordInteropEnumValue("xlDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Microsoft Word applies custom settings, such as a color or error amount, to the specified object. public enum
  /// Constants
  /// </summary>
  [WordInteropEnumValue("xlCustom")]
  Custom = -4114,
  /// <summary>
  /// Combination.
  /// </summary>
  [WordInteropEnumValue("xlCombination")]
  Combination = -4111,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue("xlCenter")]
  Center = -4108,
  /// <summary>
  /// Bottom.
  /// </summary>
  [WordInteropEnumValue("xlBottom")]
  Bottom = -4107,
  /// <summary>
  /// Microsoft Word applies automatic settings, such as a color or page number, to the specified object.
  /// </summary>
  [WordInteropEnumValue("xlAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("xl3DSurface")]
  ThreeDSurface = -4103,
  /// <summary>
  /// Specifies a miscellaneous constant in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("xl3DBar")]
  ThreeDBar = -4099,
  /// <summary>
  /// Microsoft Word applies default or automatic formatting.
  /// </summary>
  [WordInteropEnumValue("xlDefaultAutoFormat")]
  DefaultAutoFormat = -1
}
