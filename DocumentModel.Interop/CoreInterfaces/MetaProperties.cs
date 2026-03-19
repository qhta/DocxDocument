using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MetaProperties: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  MetaProperty this[object Index] { get; }
  MetaProperty GetItemByInternalName(string InternalName);
  int Count { get; }
  string Validate();
  string ValidationError { get; }
  object Parent { get; }
  string SchemaXml { get; }
  new IEnumerator GetEnumerator();
}