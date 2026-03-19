
namespace DocumentModel.Interop.Core;

public interface ICommandBarButtonEvents
{
  void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}