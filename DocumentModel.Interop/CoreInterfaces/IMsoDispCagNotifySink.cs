
namespace DocumentModel.Interop.Core;

public interface IMsoDispCagNotifySink
{
  void InsertClip(object pClipMoniker, object pItemMoniker);
  void WindowIsClosing();
}