
namespace DocumentModel.Interop.Core;

public partial interface ICommandBarButtonEvents
{
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}
