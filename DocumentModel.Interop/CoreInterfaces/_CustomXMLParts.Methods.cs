using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLParts
{
  public CustomXMLPart Add(string XML, object SchemaCollection);
  public CustomXMLPart SelectByID(string Id);
  public CustomXMLParts SelectByNamespace(string NamespaceURI);
}
