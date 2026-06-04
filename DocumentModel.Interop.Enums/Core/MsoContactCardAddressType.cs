
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardaddresstype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoContactCardAddressType")]
public enum ContactCardAddressType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardAddressTypeUnknown")]
  Unknown,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardAddressTypeOutlook")]
  Outlook,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardAddressTypeSMTP")]
  SMTP,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardAddressTypeIM")]
  IM
}
