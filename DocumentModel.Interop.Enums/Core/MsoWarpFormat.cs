namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates various image warping formats.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msowarpformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoWarpFormat")]
public enum WarpFormat
{
  /// <summary>
  /// Specifies a mix of warp formats.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormatMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies Warp Format 1.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat1")]
  Format1 = 0,
  /// <summary>
  /// Specifies Warp Format 2.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat2")]
  Format2 = 1,
  /// <summary>
  /// Specifies Warp Format 3.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat3")]
  Format3 = 2,
  /// <summary>
  /// Specifies Warp Format 4.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat4")]
  Format4 = 3,
  /// <summary>
  /// Specifies Warp Format 5.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat5")]
  Format5 = 4,
  /// <summary>
  /// Specifies Warp Format 6.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat6")]
  Format6 = 5,
  /// <summary>
  /// Specifies Warp Format 7.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat7")]
  Format7 = 6,
  /// <summary>
  /// Specifies Warp Format 8.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat8")]
  Format8 = 7,
  /// <summary>
  /// Specifies Warp Format 9.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat9")]
  Format9 = 8,
  /// <summary>
  /// Specifies Warp Format 10.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat10")]
  Format10 = 9,
  /// <summary>
  /// Specifies Warp Format 11.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat11")]
  Format11 = 10,
  /// <summary>
  /// Specifies Warp Format 12.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat12")]
  Format12 = 11,
  /// <summary>
  /// Specifies Warp Format 13.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat13")]
  Format13 = 12,
  /// <summary>
  /// Specifies Warp Format 14.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat14")]
  Format14 = 13,
  /// <summary>
  /// Specifies Warp Format 15.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat15")]
  Format15 = 14,
  /// <summary>
  /// Specifies Warp Format 16.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat16")]
  Format16 = 15,
  /// <summary>
  /// Specifies Warp Format 17.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat17")]
  Format17 = 16,
  /// <summary>
  /// Specifies Warp Format 18.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat18")]
  Format18 = 17,
  /// <summary>
  /// Specifies Warp Format 19.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat19")]
  Format19 = 18,
  /// <summary>
  /// Specifies Warp Format 20.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat20")]
  Format20 = 19,
  /// <summary>
  /// Specifies Warp Format 21.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat21")]
  Format21 = 20,
  /// <summary>
  /// Specifies Warp Format 22.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat22")]
  Format22 = 21,
  /// <summary>
  /// Specifies Warp Format 23.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat23")]
  Format23 = 22,
  /// <summary>
  /// Specifies Warp Format 24.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat24")]
  Format24 = 23,
  /// <summary>
  /// Specifies Warp Format 25.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat25")]
  Format25 = 24,
  /// <summary>
  /// Specifies Warp Format 26.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat26")]
  Format26 = 25,
  /// <summary>
  /// Specifies Warp Format 27.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat27")]
  Format27 = 26,
  /// <summary>
  /// Specifies Warp Format 28.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat28")]
  Format28 = 27,
  /// <summary>
  /// Specifies Warp Format 29.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat29")]
  Format29 = 28,
  /// <summary>
  /// Specifies Warp Format 30.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat30")]
  Format30 = 29,
  /// <summary>
  /// Specifies Warp Format 31.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat31")]
  Format31 = 30,
  /// <summary>
  /// Specifies Warp Format 32.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat32")]
  Format32 = 31,
  /// <summary>
  /// Specifies Warp Format 33.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat33")]
  Format33 = 32,
  /// <summary>
  /// Specifies Warp Format 34.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat34")]
  Format34 = 33,
  /// <summary>
  /// Specifies Warp Format 35.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat35")]
  Format35 = 34,
  /// <summary>
  /// Specifies Warp Format 36.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat36")]
  Format36 = 35,
  /// <summary>
  /// Specifies Warp Format 37.
  /// </summary>
  [OfficeInteropEnumValue("msoWarpFormat37")]
  Format37 = 36
}
