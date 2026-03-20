using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLParts: InteropDictionary<string, CustomXMLPart>
{
  CustomXMLPart Add(string XML, object SchemaCollection);
  CustomXMLPart SelectByID(string Id);
  CustomXMLParts SelectByNamespace(string NamespaceURI);
}