namespace DocumentModel.Drawings;

/// <summary>
/// Indicates the bevel type of a ThreeDFormat object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobeveltype?view=office-pia` for Office interop details.
/// </remarks>
public enum BevelType
{
  /// <summary>
  /// Specifies a mixed type bevel.
  /// </summary>
  TypeMixed = -2,
  /// <summary>
  /// Specifies no bevel.
  /// </summary>
  None = 1,
  /// <summary>
  /// Specifies a RelaxedInset bevel.
  /// </summary>
  RelaxedInset = 2,
  /// <summary>
  /// Specifies a Circle bevel.
  /// </summary>
  Circle = 3,
  /// <summary>
  /// Specifies a Slope bevel.
  /// </summary>
  Slope = 4,
  /// <summary>
  /// Specifies a Cross bevel.
  /// </summary>
  Cross = 5,
  /// <summary>
  /// Specifies an Angle bevel.
  /// </summary>
  Angle = 6,
  /// <summary>
  /// Specifies a SoftRound bevel.
  /// </summary>
  SoftRound = 7,
  /// <summary>
  /// Specifies a Convex bevel.
  /// </summary>
  Convex = 8,
  /// <summary>
  /// Specifies a CoolSlant bevel.
  /// </summary>
  CoolSlant = 9,
  /// <summary>
  /// Specifies a Divot bevel.
  /// </summary>
  Divot = 10,
  /// <summary>
  /// Specifies a Riblet bevel.
  /// </summary>
  Riblet = 11,
  /// <summary>
  /// Specifies a HardEdge bevel.
  /// </summary>
  HardEdge = 12,
  /// <summary>
  /// Specifies an ArtDeco bevel.
  /// </summary>
  ArtDeco = 13
}
