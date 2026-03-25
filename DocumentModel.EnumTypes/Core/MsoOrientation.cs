namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an object when it is displayed or printed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoOrientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Horizontal (landscape) orientation.
  /// </summary>
  Horizontal = 1,
  /// <summary>
  /// Vertical (portrait) orientation.
  /// </summary>
  Vertical = 2
}
