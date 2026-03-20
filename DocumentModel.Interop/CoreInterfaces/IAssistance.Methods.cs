
namespace DocumentModel.Interop.Core;

public partial interface IAssistance
{
  public void ShowHelp(string HelpId, string Scope);
  public void SearchHelp(string Query, string Scope);
  public void SetDefaultContext(string HelpId);
  public void ClearDefaultContext(string HelpId);
}
