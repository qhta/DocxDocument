using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMappings: InteropDictionary<string, CustomXMLPrefixMapping>
{
  void AddNamespace(string Prefix, string NamespaceURI);
  string LookupNamespace(string Prefix);
  string LookupPrefix(string NamespaceURI);
}