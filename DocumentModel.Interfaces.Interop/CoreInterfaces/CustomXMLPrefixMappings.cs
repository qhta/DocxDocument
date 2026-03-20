using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMappings: InteropObject, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  CustomXMLPrefixMapping this[object Index] { get; }
  void AddNamespace(string Prefix, string NamespaceURI);
  string LookupNamespace(string Prefix);
  string LookupPrefix(string NamespaceURI);
  new IEnumerator GetEnumerator();
}