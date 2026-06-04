namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the bevel type of a ThreeDFormat object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobeveltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBevelType")]
public enum BevelType
{
  /// <summary>
  /// Specifies a mixed type bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelTypeMixed")]
  TypeMixed = -2,
  /// <summary>
  /// Specifies no bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelNone")]
  None = 1,
  /// <summary>
  /// Specifies a RelaxedInset bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelRelaxedInset")]
  RelaxedInset = 2,
  /// <summary>
  /// Specifies a Circle bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelCircle")]
  Circle = 3,
  /// <summary>
  /// Specifies a Slope bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelSlope")]
  Slope = 4,
  /// <summary>
  /// Specifies a Cross bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelCross")]
  Cross = 5,
  /// <summary>
  /// Specifies an Angle bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelAngle")]
  Angle = 6,
  /// <summary>
  /// Specifies a SoftRound bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelSoftRound")]
  SoftRound = 7,
  /// <summary>
  /// Specifies a Convex bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelConvex")]
  Convex = 8,
  /// <summary>
  /// Specifies a CoolSlant bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelCoolSlant")]
  CoolSlant = 9,
  /// <summary>
  /// Specifies a Divot bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelDivot")]
  Divot = 10,
  /// <summary>
  /// Specifies a Riblet bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelRiblet")]
  Riblet = 11,
  /// <summary>
  /// Specifies a HardEdge bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelHardEdge")]
  HardEdge = 12,
  /// <summary>
  /// Specifies an ArtDeco bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoBevelArtDeco")]
  ArtDeco = 13
}
