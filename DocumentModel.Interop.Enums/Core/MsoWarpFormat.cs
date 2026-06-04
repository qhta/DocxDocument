namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates various image warping formats.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msowarpformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoWarpFormat))]
public enum WarpFormat
{
  /// <summary>
  /// Specifies a mix of warp formats.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormatMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies Warp Format 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat1))]
  Format1 = 0,
  /// <summary>
  /// Specifies Warp Format 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat2))]
  Format2 = 1,
  /// <summary>
  /// Specifies Warp Format 3.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat3))]
  Format3 = 2,
  /// <summary>
  /// Specifies Warp Format 4.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat4))]
  Format4 = 3,
  /// <summary>
  /// Specifies Warp Format 5.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat5))]
  Format5 = 4,
  /// <summary>
  /// Specifies Warp Format 6.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat6))]
  Format6 = 5,
  /// <summary>
  /// Specifies Warp Format 7.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat7))]
  Format7 = 6,
  /// <summary>
  /// Specifies Warp Format 8.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat8))]
  Format8 = 7,
  /// <summary>
  /// Specifies Warp Format 9.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat9))]
  Format9 = 8,
  /// <summary>
  /// Specifies Warp Format 10.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat10))]
  Format10 = 9,
  /// <summary>
  /// Specifies Warp Format 11.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat11))]
  Format11 = 10,
  /// <summary>
  /// Specifies Warp Format 12.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat12))]
  Format12 = 11,
  /// <summary>
  /// Specifies Warp Format 13.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat13))]
  Format13 = 12,
  /// <summary>
  /// Specifies Warp Format 14.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat14))]
  Format14 = 13,
  /// <summary>
  /// Specifies Warp Format 15.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat15))]
  Format15 = 14,
  /// <summary>
  /// Specifies Warp Format 16.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat16))]
  Format16 = 15,
  /// <summary>
  /// Specifies Warp Format 17.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat17))]
  Format17 = 16,
  /// <summary>
  /// Specifies Warp Format 18.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat18))]
  Format18 = 17,
  /// <summary>
  /// Specifies Warp Format 19.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat19))]
  Format19 = 18,
  /// <summary>
  /// Specifies Warp Format 20.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat20))]
  Format20 = 19,
  /// <summary>
  /// Specifies Warp Format 21.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat21))]
  Format21 = 20,
  /// <summary>
  /// Specifies Warp Format 22.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat22))]
  Format22 = 21,
  /// <summary>
  /// Specifies Warp Format 23.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat23))]
  Format23 = 22,
  /// <summary>
  /// Specifies Warp Format 24.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat24))]
  Format24 = 23,
  /// <summary>
  /// Specifies Warp Format 25.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat25))]
  Format25 = 24,
  /// <summary>
  /// Specifies Warp Format 26.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat26))]
  Format26 = 25,
  /// <summary>
  /// Specifies Warp Format 27.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat27))]
  Format27 = 26,
  /// <summary>
  /// Specifies Warp Format 28.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat28))]
  Format28 = 27,
  /// <summary>
  /// Specifies Warp Format 29.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat29))]
  Format29 = 28,
  /// <summary>
  /// Specifies Warp Format 30.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat30))]
  Format30 = 29,
  /// <summary>
  /// Specifies Warp Format 31.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat31))]
  Format31 = 30,
  /// <summary>
  /// Specifies Warp Format 32.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat32))]
  Format32 = 31,
  /// <summary>
  /// Specifies Warp Format 33.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat33))]
  Format33 = 32,
  /// <summary>
  /// Specifies Warp Format 34.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat34))]
  Format34 = 33,
  /// <summary>
  /// Specifies Warp Format 35.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat35))]
  Format35 = 34,
  /// <summary>
  /// Specifies Warp Format 36.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat36))]
  Format36 = 35,
  /// <summary>
  /// Specifies Warp Format 37.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWarpFormat.msoWarpFormat37))]
  Format37 = 36
}
