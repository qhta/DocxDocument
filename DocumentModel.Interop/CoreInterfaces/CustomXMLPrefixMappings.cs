using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMappings: InteropDictionary<string, CustomXMLPrefixMapping>
{
  public void AddNamespace(string Prefix, string NamespaceURI);
  public string LookupNamespace(string Prefix);
  public string LookupPrefix(string NamespaceURI);
}
