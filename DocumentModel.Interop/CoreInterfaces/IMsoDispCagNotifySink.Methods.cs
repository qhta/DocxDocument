
namespace DocumentModel.Interop.Core;

public partial interface IMsoDispCagNotifySink
{
  public void InsertClip(object pClipMoniker, object pItemMoniker);
  public void WindowIsClosing();
}
