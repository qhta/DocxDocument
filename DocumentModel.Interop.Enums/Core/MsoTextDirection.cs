namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextdirection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTextDirection")]
public enum TextDirection
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextDirectionLeftToRight")]
  LeftToRight = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextDirectionRightToLeft")]
  RightToLeft = 2
}
