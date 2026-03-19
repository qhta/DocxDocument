
namespace DocumentModel.Interop.Core;

public interface IConverterUICallback
{
  void HrReportProgress(uint uPercentComplete);
  void HrMessageBox(string bstrText, string bstrCaption, uint uType, out int pidResult);
  void HrInputBox(string bstrText, string bstrCaption, out string pbstrInput, int fPassword);
}