
namespace DocumentModel.Interop.Core;

public interface IConverterPreferences
{
  void HrGetMacroEnabled(out int pfMacroEnabled);
  void HrCheckFormat(out int pFormat);
  void HrGetLossySave(out int pfLossySave);
}