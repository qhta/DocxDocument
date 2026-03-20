
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IConverterPreferences` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IConverterPreferences
{
  /// <summary>
  /// Invokes `HrGetMacroEnabled`.
  /// </summary>
  /// <param name="pfMacroEnabled">The `pfMacroEnabled` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrgetmacroenabled?view=office-pia
  /// </remarks>
  public void HrGetMacroEnabled(out int pfMacroEnabled);
  /// <summary>
  /// Invokes `HrCheckFormat`.
  /// </summary>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrcheckformat?view=office-pia
  /// </remarks>
  public void HrCheckFormat(out int pFormat);
  /// <summary>
  /// Invokes `HrGetLossySave`.
  /// </summary>
  /// <param name="pfLossySave">The `pfLossySave` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterpreferences.hrgetlossysave?view=office-pia
  /// </remarks>
  public void HrGetLossySave(out int pfLossySave);
}
