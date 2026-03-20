using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentInspector: InteropObject
{
  public string Name { get; }
  public string Description { get; }
  public void Inspect(out MsoDocInspectorStatus Status, out string Results);
  public void Fix(out MsoDocInspectorStatus Status, out string Results);
}
