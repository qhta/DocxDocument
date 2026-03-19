
namespace DocumentModel.Interop.Core;

public delegate void _CommandBarButtonEvents_ClickEventHandler(CommandBarButton Ctrl, ref bool CancelDefault);

public interface _CommandBarButtonEvents_Event
{
  event _CommandBarButtonEvents_ClickEventHandler Click;
}