
namespace DocumentModel.Interop.Core;

public interface ICommandBarButtonEvents
{
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}
