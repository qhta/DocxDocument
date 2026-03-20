using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Script: InteropObject
{
  public string Extended { get; set; }
  public string Id { get; set; }
  public MsoScriptLanguage Language { get; set; }
  public MsoScriptLocation Location { get; }
  public void Delete();
  public object Shape { get; }
  public string ScriptText { get; set; }
}
