
namespace DocumentModel.Interop.Core;

public partial interface IDocumentInspector
{
  public void GetInfo(out string Name, out string Desc);
  public void Inspect(object Doc, out MsoDocInspectorStatus Status, out string Result, out string Action);
  public void Fix(object Doc, int hwnd, out MsoDocInspectorStatus Status, out string Result);
}
