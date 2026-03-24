
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontactcardaddresstype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoContactCardAddressType
{
  /// <summary>
  /// msoContactCardAddressTypeOutlook 1
  /// </summary>
  Unknown,
  /// <summary>
  /// msoContactCardAddressTypeSMTP 2
  /// </summary>
  Outlook,
  /// <summary>
  /// msoContactCardAddressTypeIM 3
  /// </summary>
  SMTP,
  /// <summary>
  /// Applies to Product Versions Office primary interop assembly Latest public enum class MsoContactCardAddressType
  /// ﾉ Expand table
  /// </summary>
  IM
}
