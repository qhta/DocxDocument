using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Script: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Extended { get; set; }
  string Id { get; set; }
  MsoScriptLanguage Language { get; set; }
  MsoScriptLocation Location { get; }
  void Delete();
  object Shape { get; }
  string ScriptText { get; set; }
}