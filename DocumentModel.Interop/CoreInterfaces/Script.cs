using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Script: InteropObject
{
  string Extended { get; set; }
  string Id { get; set; }
  MsoScriptLanguage Language { get; set; }
  MsoScriptLocation Location { get; }
  void Delete();
  object Shape { get; }
  string ScriptText { get; set; }
}