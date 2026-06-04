
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoContactCardType))]
public enum ContactCardType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardType.msoContactCardTypeEnterpriseContact))]
  EnterpriseContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardType.msoContactCardTypePersonalContact))]
  PersonalContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardType.msoContactCardTypeUnknownContact))]
  UnknownContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardType.msoContactCardTypeEnterpriseGroup))]
  EnterpriseGroup,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoContactCardType.msoContactCardTypePersonalDistributionList))]
  PersonalDistributionList
}
