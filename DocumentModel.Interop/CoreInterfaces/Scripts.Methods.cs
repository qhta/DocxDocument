using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Scripts
{
  public Script Item(object Index);
  public Script Add
  (object Anchor, MsoScriptLocation Location,
    MsoScriptLanguage Language, string Id, string Extended,
    string ScriptText);
  public void Delete();
}
