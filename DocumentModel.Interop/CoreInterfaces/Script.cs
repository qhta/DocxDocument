using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Script: InteropObject
{
  public string Extended { get; set; }
  public string Id { get; set; }
  public MsoScriptLanguage Language { get; set; }
  public MsoScriptLocation Location { get; }
  public object Shape { get; }
  public string ScriptText { get; set; }
}
