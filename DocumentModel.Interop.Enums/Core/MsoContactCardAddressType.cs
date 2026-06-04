
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardaddresstype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoContactCardAddressType")]
public enum ContactCardAddressType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardAddressTypeUnknown")]
  Unknown,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardAddressTypeOutlook")]
  Outlook,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardAddressTypeSMTP")]
  SMTP,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardAddressTypeIM")]
  IM
}
