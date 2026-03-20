
namespace DocumentModel.Interop.Core;

public interface IConverterApplicationPreferences
{
  public void HrGetLcid(out uint plcid);
  public void HrGetHwnd(out int phwnd);
  public void HrGetApplication(out string pbstrApplication);
  public void HrCheckFormat(out int pFormat);
}
