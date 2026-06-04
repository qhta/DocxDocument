
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoContactCardStyle")]
public enum ContactCardStyle
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardHover")]
  Hover,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardFull")]
  Full
}
