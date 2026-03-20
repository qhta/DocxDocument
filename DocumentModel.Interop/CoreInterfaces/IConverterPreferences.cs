
namespace DocumentModel.Interop.Core;

public interface IConverterPreferences
{
  public void HrGetMacroEnabled(out int pfMacroEnabled);
  public void HrCheckFormat(out int pFormat);
  public void HrGetLossySave(out int pfLossySave);
}
