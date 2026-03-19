
namespace DocumentModel.Interop.Core;

public interface IConverterApplicationPreferences
{
  void HrGetLcid(out uint plcid);
  void HrGetHwnd(out int phwnd);
  void HrGetApplication(out string pbstrApplication);
  void HrCheckFormat(out int pFormat);
}