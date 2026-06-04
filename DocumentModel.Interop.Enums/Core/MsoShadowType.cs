namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of shadow displayed with a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshadowtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoShadowType))]
public enum ShadowType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadowMixed))]
  Mixed = -2,
  /// <summary>
  /// First shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow1))]
  Type1 = 1,
  /// <summary>
  /// Second shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow2))]
  Type2 = 2,
  /// <summary>
  /// Third shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow3))]
  Type3 = 3,
  /// <summary>
  /// Fourth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow4))]
  Type4 = 4,
  /// <summary>
  /// Fifth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow5))]
  Type5 = 5,
  /// <summary>
  /// Sixth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow6))]
  Type6 = 6,
  /// <summary>
  /// Seventh shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow7))]
  Type7 = 7,
  /// <summary>
  /// Eighth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow8))]
  Type8 = 8,
  /// <summary>
  /// Ninth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow9))]
  Type9 = 9,
  /// <summary>
  /// Tenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow10))]
  Type10 = 10,
  /// <summary>
  /// Eleventh shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow11))]
  Type11 = 11,
  /// <summary>
  /// Twelfth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow12))]
  Type12 = 12,
  /// <summary>
  /// Thirteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow13))]
  Type13 = 13,
  /// <summary>
  /// Fourteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow14))]
  Type14 = 14,
  /// <summary>
  /// Fifteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow15))]
  Type15 = 15,
  /// <summary>
  /// Sixteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow16))]
  Type16 = 16,
  /// <summary>
  /// Seventeenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow17))]
  Type17 = 17,
  /// <summary>
  /// Eighteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow18))]
  Type18 = 18,
  /// <summary>
  /// Nineteenth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow19))]
  Type19 = 19,
  /// <summary>
  /// Twentieth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow20))]
  Type20 = 20,
  /// <summary>
  /// Twenty first shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow21))]
  Type21 = 21,
  /// <summary>
  /// Twenty second shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow22))]
  Type22 = 22,
  /// <summary>
  /// Twenty third shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow23))]
  Type23 = 23,
  /// <summary>
  /// Twenty forth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow24))]
  Type24 = 24,
  /// <summary>
  /// Twenty fifth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow25))]
  Type25 = 25,
  /// <summary>
  /// Twenty sixth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow26))]
  Type26 = 26,
  /// <summary>
  /// Twenty seventh shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow27))]
  Type27 = 27,
  /// <summary>
  /// Twenty eighth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow28))]
  Type28 = 28,
  /// <summary>
  /// Twenty ninth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow29))]
  Type29 = 29,
  /// <summary>
  /// Thirtieth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow30))]
  Type30 = 30,
  /// <summary>
  /// Thirty first shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow31))]
  Type31 = 31,
  /// <summary>
  /// Thirty second shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow32))]
  Type32 = 32,
  /// <summary>
  /// Thirty third shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow33))]
  Type33 = 33,
  /// <summary>
  /// Thirty forth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow34))]
  Type34 = 34,
  /// <summary>
  /// Thirty fifth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow35))]
  Type35 = 35,
  /// <summary>
  /// Thirty sixth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow36))]
  Type36 = 36,
  /// <summary>
  /// Thirty seventh shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow37))]
  Type37 = 37,
  /// <summary>
  /// Thirty eighth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow38))]
  Type38 = 38,
  /// <summary>
  /// Thirty ninth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow39))]
  Type39 = 39,
  /// <summary>
  /// Fortieth shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow40))]
  Type40 = 40,
  /// <summary>
  /// Forty first shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow41))]
  Type41 = 41,
  /// <summary>
  /// Forty second shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow42))]
  Type42 = 42,
  /// <summary>
  /// Forty third shadow type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShadowType.msoShadow43))]
  Type43 = 43
}
