using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Scripts: InteropObject, IEnumerable
{
  int Count { get; }
  new IEnumerator GetEnumerator();
  Script Item(object Index);

  Script Add
  (object Anchor, MsoScriptLocation Location,
    MsoScriptLanguage Language, string Id, string Extended,
    string ScriptText);

  void Delete();
}