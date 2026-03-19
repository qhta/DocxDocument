using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLParts: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  CustomXMLPart this[object Index] { get; }
  CustomXMLPart Add(string XML, object SchemaCollection);
  CustomXMLPart SelectByID(string Id);
  CustomXMLParts SelectByNamespace(string NamespaceURI);
  new IEnumerator GetEnumerator();
}