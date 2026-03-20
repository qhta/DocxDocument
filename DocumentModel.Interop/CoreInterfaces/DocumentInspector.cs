using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentInspector: InteropObject
{
  string Name { get; }
  string Description { get; }
  void Inspect(out MsoDocInspectorStatus Status, out string Results);
  void Fix(out MsoDocInspectorStatus Status, out string Results);
}