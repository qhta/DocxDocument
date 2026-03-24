
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardtype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoContactCardType
{
  /// <summary>
  /// msoContactCardTypePersonalContact 1
  /// </summary>
  EnterpriseContact,
  /// <summary>
  /// msoContactCardTypeUnknownContact 2
  /// </summary>
  PersonalContact,
  /// <summary>
  /// msoContactCardTypeEnterpriseGroup 3
  /// </summary>
  UnknownContact,
  /// <summary>
  /// msoContactCardTypePersonalDistributionList 4
  /// </summary>
  EnterpriseGroup,
  /// <summary>
  /// Applies to Product Versions Office primary interop assembly Latest public enum class MsoContactCardType ﾉ
  /// Expand table
  /// </summary>
  PersonalDistributionList
}
