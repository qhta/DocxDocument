
namespace DocumentModel.Interop.Core;

public interface IConverterUICallback
{
  public void HrReportProgress(uint uPercentComplete);
  public void HrMessageBox(string bstrText, string bstrCaption, uint uType, out int pidResult);
  public void HrInputBox(string bstrText, string bstrCaption, out string pbstrInput, int fPassword);
}
