namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the bevel type of a ThreeDFormat object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobeveltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBevelType")]
public enum BevelType
{
  /// <summary>
  /// Specifies a mixed type bevel.
  /// </summary>
  [InteropEnumValue("msoBevelTypeMixed")]
  TypeMixed = -2,
  /// <summary>
  /// Specifies no bevel.
  /// </summary>
  [InteropEnumValue("msoBevelNone")]
  None = 1,
  /// <summary>
  /// Specifies a RelaxedInset bevel.
  /// </summary>
  [InteropEnumValue("msoBevelRelaxedInset")]
  RelaxedInset = 2,
  /// <summary>
  /// Specifies a Circle bevel.
  /// </summary>
  [InteropEnumValue("msoBevelCircle")]
  Circle = 3,
  /// <summary>
  /// Specifies a Slope bevel.
  /// </summary>
  [InteropEnumValue("msoBevelSlope")]
  Slope = 4,
  /// <summary>
  /// Specifies a Cross bevel.
  /// </summary>
  [InteropEnumValue("msoBevelCross")]
  Cross = 5,
  /// <summary>
  /// Specifies an Angle bevel.
  /// </summary>
  [InteropEnumValue("msoBevelAngle")]
  Angle = 6,
  /// <summary>
  /// Specifies a SoftRound bevel.
  /// </summary>
  [InteropEnumValue("msoBevelSoftRound")]
  SoftRound = 7,
  /// <summary>
  /// Specifies a Convex bevel.
  /// </summary>
  [InteropEnumValue("msoBevelConvex")]
  Convex = 8,
  /// <summary>
  /// Specifies a CoolSlant bevel.
  /// </summary>
  [InteropEnumValue("msoBevelCoolSlant")]
  CoolSlant = 9,
  /// <summary>
  /// Specifies a Divot bevel.
  /// </summary>
  [InteropEnumValue("msoBevelDivot")]
  Divot = 10,
  /// <summary>
  /// Specifies a Riblet bevel.
  /// </summary>
  [InteropEnumValue("msoBevelRiblet")]
  Riblet = 11,
  /// <summary>
  /// Specifies a HardEdge bevel.
  /// </summary>
  [InteropEnumValue("msoBevelHardEdge")]
  HardEdge = 12,
  /// <summary>
  /// Specifies an ArtDeco bevel.
  /// </summary>
  [InteropEnumValue("msoBevelArtDeco")]
  ArtDeco = 13
}
