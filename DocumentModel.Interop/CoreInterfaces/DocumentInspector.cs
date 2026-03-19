using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentInspector: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  string Description { get; }
  void Inspect(out MsoDocInspectorStatus Status, out string Results);
  void Fix(out MsoDocInspectorStatus Status, out string Results);
  object Parent { get; }
}