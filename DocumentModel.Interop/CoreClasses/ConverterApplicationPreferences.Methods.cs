
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines application preferences used by Office document converters.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences?view=office-pia"/>
public partial class ConverterApplicationPreferences
{
  /// <summary>
  /// Gets the current locale identifier.
  /// </summary>
  /// <param name="plcid">The `plcid` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgetlcid?view=office-pia"/>
  public void HrGetLcid(out uint plcid) { throw new NotImplementedException(); }
  /// <summary>
  /// Gets the host application window handle.
  /// </summary>
  /// <param name="phwnd">The `phwnd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgethwnd?view=office-pia"/>
  public void HrGetHwnd(out int phwnd) { throw new NotImplementedException(); }
  /// <summary>
  /// Gets the host application name.
  /// </summary>
  /// <param name="pbstrApplication">The `pbstrApplication` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrgetapplication?view=office-pia"/>
  public void HrGetApplication(out string pbstrApplication) { throw new NotImplementedException(); }
  /// <summary>
  /// Gets format-related information for the converter.
  /// </summary>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverterapplicationpreferences.hrcheckformat?view=office-pia"/>
  public void HrCheckFormat(out int pFormat) { throw new NotImplementedException(); }
}


