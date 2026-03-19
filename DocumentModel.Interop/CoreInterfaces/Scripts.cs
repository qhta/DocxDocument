using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Scripts: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  Script Item(object Index);

  Script Add
  (object Anchor, MsoScriptLocation Location = MsoScriptLocation.msoScriptLocationInBody,
    MsoScriptLanguage Language = MsoScriptLanguage.msoScriptLanguageVisualBasic, string Id = "", string Extended = "",
    string ScriptText = "");

  void Delete();
}