namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of shadow displayed with a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshadowtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoShadowType")]
public enum ShadowType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoShadowMixed")]
  Mixed = -2,
  /// <summary>
  /// First shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow1")]
  Type1 = 1,
  /// <summary>
  /// Second shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow2")]
  Type2 = 2,
  /// <summary>
  /// Third shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow3")]
  Type3 = 3,
  /// <summary>
  /// Fourth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow4")]
  Type4 = 4,
  /// <summary>
  /// Fifth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow5")]
  Type5 = 5,
  /// <summary>
  /// Sixth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow6")]
  Type6 = 6,
  /// <summary>
  /// Seventh shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow7")]
  Type7 = 7,
  /// <summary>
  /// Eighth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow8")]
  Type8 = 8,
  /// <summary>
  /// Ninth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow9")]
  Type9 = 9,
  /// <summary>
  /// Tenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow10")]
  Type10 = 10,
  /// <summary>
  /// Eleventh shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow11")]
  Type11 = 11,
  /// <summary>
  /// Twelfth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow12")]
  Type12 = 12,
  /// <summary>
  /// Thirteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow13")]
  Type13 = 13,
  /// <summary>
  /// Fourteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow14")]
  Type14 = 14,
  /// <summary>
  /// Fifteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow15")]
  Type15 = 15,
  /// <summary>
  /// Sixteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow16")]
  Type16 = 16,
  /// <summary>
  /// Seventeenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow17")]
  Type17 = 17,
  /// <summary>
  /// Eighteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow18")]
  Type18 = 18,
  /// <summary>
  /// Nineteenth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow19")]
  Type19 = 19,
  /// <summary>
  /// Twentieth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow20")]
  Type20 = 20,
  /// <summary>
  /// Twenty first shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow21")]
  Type21 = 21,
  /// <summary>
  /// Twenty second shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow22")]
  Type22 = 22,
  /// <summary>
  /// Twenty third shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow23")]
  Type23 = 23,
  /// <summary>
  /// Twenty forth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow24")]
  Type24 = 24,
  /// <summary>
  /// Twenty fifth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow25")]
  Type25 = 25,
  /// <summary>
  /// Twenty sixth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow26")]
  Type26 = 26,
  /// <summary>
  /// Twenty seventh shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow27")]
  Type27 = 27,
  /// <summary>
  /// Twenty eighth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow28")]
  Type28 = 28,
  /// <summary>
  /// Twenty ninth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow29")]
  Type29 = 29,
  /// <summary>
  /// Thirtieth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow30")]
  Type30 = 30,
  /// <summary>
  /// Thirty first shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow31")]
  Type31 = 31,
  /// <summary>
  /// Thirty second shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow32")]
  Type32 = 32,
  /// <summary>
  /// Thirty third shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow33")]
  Type33 = 33,
  /// <summary>
  /// Thirty forth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow34")]
  Type34 = 34,
  /// <summary>
  /// Thirty fifth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow35")]
  Type35 = 35,
  /// <summary>
  /// Thirty sixth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow36")]
  Type36 = 36,
  /// <summary>
  /// Thirty seventh shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow37")]
  Type37 = 37,
  /// <summary>
  /// Thirty eighth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow38")]
  Type38 = 38,
  /// <summary>
  /// Thirty ninth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow39")]
  Type39 = 39,
  /// <summary>
  /// Fortieth shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow40")]
  Type40 = 40,
  /// <summary>
  /// Forty first shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow41")]
  Type41 = 41,
  /// <summary>
  /// Forty second shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow42")]
  Type42 = 42,
  /// <summary>
  /// Forty third shadow type.
  /// </summary>
  [InteropEnumValue("msoShadow43")]
  Type43 = 43
}
