
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoContactCardType")]
public enum ContactCardType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardTypeEnterpriseContact")]
  EnterpriseContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardTypePersonalContact")]
  PersonalContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardTypeUnknownContact")]
  UnknownContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardTypeEnterpriseGroup")]
  EnterpriseGroup,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoContactCardTypePersonalDistributionList")]
  PersonalDistributionList
}
