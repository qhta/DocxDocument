namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the bevel type of a ThreeDFormat object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobeveltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBevelType))]
public enum BevelType
{
  /// <summary>
  /// Specifies a mixed type bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelTypeMixed))]
  TypeMixed = -2,
  /// <summary>
  /// Specifies no bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelNone))]
  None = 1,
  /// <summary>
  /// Specifies a RelaxedInset bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelRelaxedInset))]
  RelaxedInset = 2,
  /// <summary>
  /// Specifies a Circle bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelCircle))]
  Circle = 3,
  /// <summary>
  /// Specifies a Slope bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelSlope))]
  Slope = 4,
  /// <summary>
  /// Specifies a Cross bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelCross))]
  Cross = 5,
  /// <summary>
  /// Specifies an Angle bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelAngle))]
  Angle = 6,
  /// <summary>
  /// Specifies a SoftRound bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelSoftRound))]
  SoftRound = 7,
  /// <summary>
  /// Specifies a Convex bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelConvex))]
  Convex = 8,
  /// <summary>
  /// Specifies a CoolSlant bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelCoolSlant))]
  CoolSlant = 9,
  /// <summary>
  /// Specifies a Divot bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelDivot))]
  Divot = 10,
  /// <summary>
  /// Specifies a Riblet bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelRiblet))]
  Riblet = 11,
  /// <summary>
  /// Specifies a HardEdge bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelHardEdge))]
  HardEdge = 12,
  /// <summary>
  /// Specifies an ArtDeco bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBevelType.msoBevelArtDeco))]
  ArtDeco = 13
}
