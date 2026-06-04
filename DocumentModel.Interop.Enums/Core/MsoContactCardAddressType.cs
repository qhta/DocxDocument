
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardaddresstype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoContactCardAddressType))]
public enum ContactCardAddressType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardAddressType.msoContactCardAddressTypeUnknown))]
  Unknown,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardAddressType.msoContactCardAddressTypeOutlook))]
  Outlook,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardAddressType.msoContactCardAddressTypeSMTP))]
  SMTP,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardAddressType.msoContactCardAddressTypeIM))]
  IM
}
