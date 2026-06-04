
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies global
/// constants used in Microsoft Excel.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlconstants?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlConstants))]
public enum Constants
{
  /// <summary>
  /// -4105
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlAutomatic))]
  Automatic = -4105,
  /// <summary>
  /// -4111
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCombination))]
  Combination = -4111,
  /// <summary>
  /// -4114
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCustom))]
  Custom = -4114,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlBar))]
  Bar = 2,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlColumn))]
  Column = 3,
  /// <summary>
  /// -4099
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xl3DBar))]
  ThreeDBar = -4099,
  /// <summary>
  /// -4103
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xl3DSurface))]
  ThreeDSurface = -4103,
  /// <summary>
  /// -1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlDefaultAutoFormat))]
  DefaultAutoFormat = -1,
  /// <summary>
  /// -4142
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlNone))]
  None = -4142,
  /// <summary>
  /// 0
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlAbove))]
  Above = 0,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlBelow))]
  Below = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlBoth))]
  Both = 1,
  /// <summary>
  /// -4017
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlBottom))]
  Bottom = -4107,
  /// <summary>
  /// -4108
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCenter))]
  Center = -4108,
  /// <summary>
  /// 9
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlChecker))]
  Checker = 9,
  /// <summary>
  /// 8
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCircle))]
  Circle = 8,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCorner))]
  Corner = 2,
  /// <summary>
  /// 16
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCrissCross))]
  CrissCross = 16,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlCross))]
  Cross = 4,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlDiamond))]
  Diamond = 2,
  /// <summary>
  /// -4117
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlDistributed))]
  Distributed = -4117,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlFill))]
  Fill = 5,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlFixedValue))]
  FixedValue = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGeneral))]
  General = 1,
  /// <summary>
  /// 17
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGray16))]
  Gray16 = 17,
  /// <summary>
  /// -4124
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGray25))]
  Gray25 = -4124,
  /// <summary>
  /// -4125
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGray50))]
  Gray50 = -4125,
  /// <summary>
  /// 10
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGray75))]
  Gray75 = -4126,
  /// <summary>
  /// 18
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGray8))]
  Gray8 = 18,
  /// <summary>
  /// 15
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlGrid))]
  Grid = 15,
  /// <summary>
  /// -4127
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlHigh))]
  High = -4127,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlInside))]
  Inside = 2,
  /// <summary>
  /// -4130
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlJustify))]
  Justify = -4130,
  /// <summary>
  /// -4131
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLeft))]
  Left = -4131,
  /// <summary>
  /// 13
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLightDown))]
  LightDown = 13,
  /// <summary>
  /// 11
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLightHorizontal))]
  LightHorizontal = 11,
  /// <summary>
  /// 14
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLightUp))]
  LightUp = 14,
  /// <summary>
  /// 12
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLightVertical))]
  LightVertical = 12,
  /// <summary>
  /// -4134
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlLow))]
  Low = -4134,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlMaximum))]
  Maximum = 2,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlMinimum))]
  Minimum = 4,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlMinusValues))]
  MinusValues = 3,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlNextToAxis))]
  NextToAxis = 4,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlOpaque))]
  Opaque = 3,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlOutside))]
  Outside = 3,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlPercent))]
  Percent = 2,
  /// <summary>
  /// 9
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlPlus))]
  Plus = 9,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlPlusValues))]
  PlusValues = 2,
  /// <summary>
  /// -4152
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlRight))]
  Right = -4152,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlScale))]
  Scale = 3,
  /// <summary>
  /// 10
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlSemiGray75))]
  SemiGray75 = 10,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlShowLabel))]
  ShowLabel = 4,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlShowLabelAndPercent))]
  ShowLabelAndPercent = 5,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlShowPercent))]
  ShowPercent = 3,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlShowValue))]
  ShowValue = 2,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlSingle))]
  Single = 2,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlSolid))]
  Solid = 1,
  /// <summary>
  /// 1
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlSquare))]
  Square = 1,
  /// <summary>
  /// 5
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlStar))]
  Star = 5,
  /// <summary>
  /// 4
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlStError))]
  StError = 4,
  /// <summary>
  /// -4160
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlTop))]
  Top = -4160,
  /// <summary>
  /// 2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlTransparent))]
  Transparent = 2,
  /// <summary>
  /// 3
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlConstants.xlTriangle))]
  Triangle = 3
}
