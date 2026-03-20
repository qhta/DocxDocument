using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DocumentInspector
{
  public void Inspect(out MsoDocInspectorStatus Status, out string Results);
  public void Fix(out MsoDocInspectorStatus Status, out string Results);
}
