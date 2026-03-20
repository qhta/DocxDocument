
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IConverterApplicationPreferences` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IConverterApplicationPreferences
{
  /// <summary>
  /// Invokes `HrGetLcid`.
  /// </summary>
  /// <param name="plcid">The `plcid` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgetlcid?view=office-pia
  /// </remarks>
  public void HrGetLcid(out uint plcid);
  /// <summary>
  /// Invokes `HrGetHwnd`.
  /// </summary>
  /// <param name="phwnd">The `phwnd` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgethwnd?view=office-pia
  /// </remarks>
  public void HrGetHwnd(out int phwnd);
  /// <summary>
  /// Invokes `HrGetApplication`.
  /// </summary>
  /// <param name="pbstrApplication">The `pbstrApplication` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgetapplication?view=office-pia
  /// </remarks>
  public void HrGetApplication(out string pbstrApplication);
  /// <summary>
  /// Invokes `HrCheckFormat`.
  /// </summary>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrcheckformat?view=office-pia
  /// </remarks>
  public void HrCheckFormat(out int pFormat);
}
