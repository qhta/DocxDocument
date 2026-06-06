
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoContactCardType")]
public enum ContactCardType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardTypeEnterpriseContact")]
  EnterpriseContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardTypePersonalContact")]
  PersonalContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardTypeUnknownContact")]
  UnknownContact,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardTypeEnterpriseGroup")]
  EnterpriseGroup,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoContactCardTypePersonalDistributionList")]
  PersonalDistributionList
}
