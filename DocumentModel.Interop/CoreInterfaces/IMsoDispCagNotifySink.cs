
namespace DocumentModel.Interop.Core;

public interface IMsoDispCagNotifySink
{
  public void InsertClip(object pClipMoniker, object pItemMoniker);
  public void WindowIsClosing();
}
