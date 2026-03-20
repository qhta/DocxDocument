using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLParts: InteropDictionary<string, CustomXMLPart>
{
  public CustomXMLPart Add(string XML, object SchemaCollection);
  public CustomXMLPart SelectByID(string Id);
  public CustomXMLParts SelectByNamespace(string NamespaceURI);
}
