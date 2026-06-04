
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies global
/// constants used in Microsoft Excel.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlConstants")]
public enum Constants
{
  /// <summary>
  /// -4105
  /// </summary>
  [OfficeInteropEnumValue("xlAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// -4111
  /// </summary>
  [OfficeInteropEnumValue("xlCombination")]
  Combination = -4111,
  /// <summary>
  /// -4114
  /// </summary>
  [OfficeInteropEnumValue("xlCustom")]
  Custom = -4114,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlBar")]
  Bar = 2,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlColumn")]
  Column = 3,
  /// <summary>
  /// -4099
  /// </summary>
  [OfficeInteropEnumValue("xl3DBar")]
  ThreeDBar = -4099,
  /// <summary>
  /// -4103
  /// </summary>
  [OfficeInteropEnumValue("xl3DSurface")]
  ThreeDSurface = -4103,
  /// <summary>
  /// -1
  /// </summary>
  [OfficeInteropEnumValue("xlDefaultAutoFormat")]
  DefaultAutoFormat = -1,
  /// <summary>
  /// -4142
  /// </summary>
  [OfficeInteropEnumValue("xlNone")]
  None = -4142,
  /// <summary>
  /// 0
  /// </summary>
  [OfficeInteropEnumValue("xlAbove")]
  Above = 0,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlBelow")]
  Below = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlBoth")]
  Both = 1,
  /// <summary>
  /// -4017
  /// </summary>
  [OfficeInteropEnumValue("xlBottom")]
  Bottom = -4107,
  /// <summary>
  /// -4108
  /// </summary>
  [OfficeInteropEnumValue("xlCenter")]
  Center = -4108,
  /// <summary>
  /// 9
  /// </summary>
  [OfficeInteropEnumValue("xlChecker")]
  Checker = 9,
  /// <summary>
  /// 8
  /// </summary>
  [OfficeInteropEnumValue("xlCircle")]
  Circle = 8,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlCorner")]
  Corner = 2,
  /// <summary>
  /// 16
  /// </summary>
  [OfficeInteropEnumValue("xlCrissCross")]
  CrissCross = 16,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue("xlCross")]
  Cross = 4,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlDiamond")]
  Diamond = 2,
  /// <summary>
  /// -4117
  /// </summary>
  [OfficeInteropEnumValue("xlDistributed")]
  Distributed = -4117,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue("xlFill")]
  Fill = 5,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlFixedValue")]
  FixedValue = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlGeneral")]
  General = 1,
  /// <summary>
  /// 17
  /// </summary>
  [OfficeInteropEnumValue("xlGray16")]
  Gray16 = 17,
  /// <summary>
  /// -4124
  /// </summary>
  [OfficeInteropEnumValue("xlGray25")]
  Gray25 = -4124,
  /// <summary>
  /// -4125
  /// </summary>
  [OfficeInteropEnumValue("xlGray50")]
  Gray50 = -4125,
  /// <summary>
  /// 10
  /// </summary>
  [OfficeInteropEnumValue("xlGray75")]
  Gray75 = -4126,
  /// <summary>
  /// 18
  /// </summary>
  [OfficeInteropEnumValue("xlGray8")]
  Gray8 = 18,
  /// <summary>
  /// 15
  /// </summary>
  [OfficeInteropEnumValue("xlGrid")]
  Grid = 15,
  /// <summary>
  /// -4127
  /// </summary>
  [OfficeInteropEnumValue("xlHigh")]
  High = -4127,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlInside")]
  Inside = 2,
  /// <summary>
  /// -4130
  /// </summary>
  [OfficeInteropEnumValue("xlJustify")]
  Justify = -4130,
  /// <summary>
  /// -4131
  /// </summary>
  [OfficeInteropEnumValue("xlLeft")]
  Left = -4131,
  /// <summary>
  /// 13
  /// </summary>
  [OfficeInteropEnumValue("xlLightDown")]
  LightDown = 13,
  /// <summary>
  /// 11
  /// </summary>
  [OfficeInteropEnumValue("xlLightHorizontal")]
  LightHorizontal = 11,
  /// <summary>
  /// 14
  /// </summary>
  [OfficeInteropEnumValue("xlLightUp")]
  LightUp = 14,
  /// <summary>
  /// 12
  /// </summary>
  [OfficeInteropEnumValue("xlLightVertical")]
  LightVertical = 12,
  /// <summary>
  /// -4134
  /// </summary>
  [OfficeInteropEnumValue("xlLow")]
  Low = -4134,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlMaximum")]
  Maximum = 2,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue("xlMinimum")]
  Minimum = 4,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlMinusValues")]
  MinusValues = 3,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue("xlNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlOpaque")]
  Opaque = 3,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlOutside")]
  Outside = 3,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlPercent")]
  Percent = 2,
  /// <summary>
  /// 9
  /// </summary>
  [OfficeInteropEnumValue("xlPlus")]
  Plus = 9,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlPlusValues")]
  PlusValues = 2,
  /// <summary>
  /// -4152
  /// </summary>
  [OfficeInteropEnumValue("xlRight")]
  Right = -4152,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlScale")]
  Scale = 3,
  /// <summary>
  /// 10
  /// </summary>
  [OfficeInteropEnumValue("xlSemiGray75")]
  SemiGray75 = 10,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue("xlShowLabel")]
  ShowLabel = 4,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue("xlShowLabelAndPercent")]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlShowPercent")]
  ShowPercent = 3,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlShowValue")]
  ShowValue = 2,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlSingle")]
  Single = 2,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlSolid")]
  Solid = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue("xlSquare")]
  Square = 1,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue("xlStar")]
  Star = 5,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue("xlStError")]
  StError = 4,
  /// <summary>
  /// -4160
  /// </summary>
  [OfficeInteropEnumValue("xlTop")]
  Top = -4160,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue("xlTransparent")]
  Transparent = 2,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue("xlTriangle")]
  Triangle = 3
}
