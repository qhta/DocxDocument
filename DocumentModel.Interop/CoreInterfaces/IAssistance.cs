
namespace DocumentModel.Interop.Core;

public interface IAssistance
{
  void ShowHelp(string HelpId = "", string Scope = "");
  void SearchHelp(string Query, string Scope = "");
  void SetDefaultContext(string HelpId);
  void ClearDefaultContext(string HelpId);
}