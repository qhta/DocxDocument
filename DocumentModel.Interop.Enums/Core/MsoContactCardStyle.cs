
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoContactCardStyle")]
public enum ContactCardStyle
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardHover")]
  Hover,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardFull")]
  Full
}
