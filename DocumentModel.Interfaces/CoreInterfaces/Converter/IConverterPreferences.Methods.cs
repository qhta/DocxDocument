
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines converter-specific preferences for Office document converters.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences?view=office-pia"/>
public partial interface IConverterPreferences: InteropObject
{
  /// <summary>
  /// Gets whether macros are enabled.
  /// </summary>
  /// <param name="pfMacroEnabled">The `pfMacroEnabled` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrgetmacroenabled?view=office-pia"/>
  public void HrGetMacroEnabled(out int pfMacroEnabled);
  /// <summary>
  /// Gets format-related preference information.
  /// </summary>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrcheckformat?view=office-pia"/>
  public void HrCheckFormat(out int pFormat);
  /// <summary>
  /// Gets whether lossy save is enabled.
  /// </summary>
  /// <param name="pfLossySave">The `pfLossySave` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrgetlossysave?view=office-pia"/>
  public void HrGetLossySave(out int pfLossySave);
}

