namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextdirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextDirection")]
public enum TextDirection
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextDirectionLeftToRight")]
  LeftToRight = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextDirectionRightToLeft")]
  RightToLeft = 2
}
