
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies global
/// constants used in Microsoft Excel.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlConstants")]
public enum Constants
{
  /// <summary>
  /// -4105
  /// </summary>
  [InteropEnumValue("xlAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// -4111
  /// </summary>
  [InteropEnumValue("xlCombination")]
  Combination = -4111,
  /// <summary>
  /// -4114
  /// </summary>
  [InteropEnumValue("xlCustom")]
  Custom = -4114,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlBar")]
  Bar = 2,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlColumn")]
  Column = 3,
  /// <summary>
  /// -4099
  /// </summary>
  [InteropEnumValue("xl3DBar")]
  ThreeDBar = -4099,
  /// <summary>
  /// -4103
  /// </summary>
  [InteropEnumValue("xl3DSurface")]
  ThreeDSurface = -4103,
  /// <summary>
  /// -1
  /// </summary>
  [InteropEnumValue("xlDefaultAutoFormat")]
  DefaultAutoFormat = -1,
  /// <summary>
  /// -4142
  /// </summary>
  [InteropEnumValue("xlNone")]
  None = -4142,
  /// <summary>
  /// 0
  /// </summary>
  [InteropEnumValue("xlAbove")]
  Above = 0,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlBelow")]
  Below = 1,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlBoth")]
  Both = 1,
  /// <summary>
  /// -4017
  /// </summary>
  [InteropEnumValue("xlBottom")]
  Bottom = -4107,
  /// <summary>
  /// -4108
  /// </summary>
  [InteropEnumValue("xlCenter")]
  Center = -4108,
  /// <summary>
  /// 9
  /// </summary>
  [InteropEnumValue("xlChecker")]
  Checker = 9,
  /// <summary>
  /// 8
  /// </summary>
  [InteropEnumValue("xlCircle")]
  Circle = 8,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlCorner")]
  Corner = 2,
  /// <summary>
  /// 16
  /// </summary>
  [InteropEnumValue("xlCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 4
  /// </summary>
  [InteropEnumValue("xlCross")]
  Cross = 4,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlDiamond")]
  Diamond = 2,
  /// <summary>
  /// -4117
  /// </summary>
  [InteropEnumValue("xlDistributed")]
  Distributed = -4117,
  /// <summary>
  /// 5
  /// </summary>
  [InteropEnumValue("xlFill")]
  Fill = 5,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlFixedValue")]
  FixedValue = 1,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlGeneral")]
  General = 1,
  /// <summary>
  /// 17
  /// </summary>
  [InteropEnumValue("xlGray16")]
  Gray16 = 17,
  /// <summary>
  /// -4124
  /// </summary>
  [InteropEnumValue("xlGray25")]
  Gray25 = -4124,
  /// <summary>
  /// -4125
  /// </summary>
  [InteropEnumValue("xlGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 10
  /// </summary>
  [InteropEnumValue("xlGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 18
  /// </summary>
  [InteropEnumValue("xlGray8")]
  Gray8 = 18,
  /// <summary>
  /// 15
  /// </summary>
  [InteropEnumValue("xlGrid")]
  Grid = 15,
  /// <summary>
  /// -4127
  /// </summary>
  [InteropEnumValue("xlHigh")]
  High = -4127,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlInside")]
  Inside = 2,
  /// <summary>
  /// -4130
  /// </summary>
  [InteropEnumValue("xlJustify")]
  Justify = -4130,
  /// <summary>
  /// -4131
  /// </summary>
  [InteropEnumValue("xlLeft")]
  Left = -4131,
  /// <summary>
  /// 13
  /// </summary>
  [InteropEnumValue("xlLightDown")]
  LightDown = 13,
  /// <summary>
  /// 11
  /// </summary>
  [InteropEnumValue("xlLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// 14
  /// </summary>
  [InteropEnumValue("xlLightUp")]
  LightUp = 14,
  /// <summary>
  /// 12
  /// </summary>
  [InteropEnumValue("xlLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// -4134
  /// </summary>
  [InteropEnumValue("xlLow")]
  Low = -4134,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlMaximum")]
  Maximum = 2,
  /// <summary>
  /// 4
  /// </summary>
  [InteropEnumValue("xlMinimum")]
  Minimum = 4,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlMinusValues")]
  MinusValues = 3,
  /// <summary>
  /// 4
  /// </summary>
  [InteropEnumValue("xlNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlOpaque")]
  Opaque = 3,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlOutside")]
  Outside = 3,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlPercent")]
  Percent = 2,
  /// <summary>
  /// 9
  /// </summary>
  [InteropEnumValue("xlPlus")]
  Plus = 9,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlPlusValues")]
  PlusValues = 2,
  /// <summary>
  /// -4152
  /// </summary>
  [InteropEnumValue("xlRight")]
  Right = -4152,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlScale")]
  Scale = 3,
  /// <summary>
  /// 10
  /// </summary>
  [InteropEnumValue("xlSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// 5
  /// </summary>
  [InteropEnumValue("xlShowLabel")]
  ShowLabel = 4,
  /// <summary>
  /// 5
  /// </summary>
  [InteropEnumValue("xlShowLabelAndPercent")]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlShowPercent")]
  ShowPercent = 3,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlShowValue")]
  ShowValue = 2,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlSingle")]
  Single = 2,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlSolid")]
  Solid = 1,
  /// <summary>
  /// 1
  /// </summary>
  [InteropEnumValue("xlSquare")]
  Square = 1,
  /// <summary>
  /// 5
  /// </summary>
  [InteropEnumValue("xlStar")]
  Star = 5,
  /// <summary>
  /// 4
  /// </summary>
  [InteropEnumValue("xlStError")]
  StError = 4,
  /// <summary>
  /// -4160
  /// </summary>
  [InteropEnumValue("xlTop")]
  Top = -4160,
  /// <summary>
  /// 2
  /// </summary>
  [InteropEnumValue("xlTransparent")]
  Transparent = 2,
  /// <summary>
  /// 3
  /// </summary>
  [InteropEnumValue("xlTriangle")]
  Triangle = 3
}
