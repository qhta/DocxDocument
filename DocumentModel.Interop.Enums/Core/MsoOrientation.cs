namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an object when it is displayed or printed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoOrientation")]
public enum Orientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  [OfficeInteropEnumValue("msoOrientationMixed")]
  Mixed = -2,
  /// <summary>
  /// Horizontal (landscape) orientation.
  /// </summary>
  [OfficeInteropEnumValue("msoOrientationHorizontal")]
  Horizontal = 1,
  /// <summary>
  /// Vertical (portrait) orientation.
  /// </summary>
  [OfficeInteropEnumValue("msoOrientationVertical")]
  Vertical = 2
}
