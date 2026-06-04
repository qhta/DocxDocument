namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an object when it is displayed or printed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoOrientation))]
public enum Orientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOrientation.msoOrientationMixed))]
  Mixed = -2,
  /// <summary>
  /// Horizontal (landscape) orientation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOrientation.msoOrientationHorizontal))]
  Horizontal = 1,
  /// <summary>
  /// Vertical (portrait) orientation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOrientation.msoOrientationVertical))]
  Vertical = 2
}
