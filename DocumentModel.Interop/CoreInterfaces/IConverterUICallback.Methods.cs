
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines UI callback methods for Office document converters.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverteruicallback?view=office-pia
/// </remarks>
public partial interface IConverterUICallback
{
  /// <summary>
  /// Reports conversion progress.
  /// </summary>
  /// <param name="uPercentComplete">The `uPercentComplete` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverteruicallback.hrreportprogress?view=office-pia
  /// </remarks>
  public void HrReportProgress(uint uPercentComplete);
  /// <summary>
  /// Displays a message box through the host UI.
  /// </summary>
  /// <param name="bstrText">The `bstrText` parameter.</param>
  /// <param name="bstrCaption">The `bstrCaption` parameter.</param>
  /// <param name="uType">The `uType` parameter.</param>
  /// <param name="pidResult">The `pidResult` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverteruicallback.hrmessagebox?view=office-pia
  /// </remarks>
  public void HrMessageBox(string bstrText, string bstrCaption, uint uType, out int pidResult);
  /// <summary>
  /// Displays an input box through the host UI.
  /// </summary>
  /// <param name="bstrText">The `bstrText` parameter.</param>
  /// <param name="bstrCaption">The `bstrCaption` parameter.</param>
  /// <param name="pbstrInput">The `pbstrInput` parameter.</param>
  /// <param name="fPassword">The `fPassword` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverteruicallback.hrinputbox?view=office-pia
  /// </remarks>
  public void HrInputBox(string bstrText, string bstrCaption, out string pbstrInput, int fPassword);
}
