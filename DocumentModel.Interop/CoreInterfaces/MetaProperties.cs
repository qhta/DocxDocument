using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MetaProperties: InteropObject, IEnumerable
{
  MetaProperty this[object Index] { get; }
  MetaProperty GetItemByInternalName(string InternalName);
  int Count { get; }
  string Validate();
  string ValidationError { get; }
  string SchemaXml { get; }
  new IEnumerator GetEnumerator();
}