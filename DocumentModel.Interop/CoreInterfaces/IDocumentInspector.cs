
namespace DocumentModel.Interop.Core;

public interface IDocumentInspector
{
  void GetInfo(out string Name, out string Desc);
  void Inspect(object Doc, out MsoDocInspectorStatus Status, out string Result, out string Action);
  void Fix(object Doc, int hwnd, out MsoDocInspectorStatus Status, out string Result);
}