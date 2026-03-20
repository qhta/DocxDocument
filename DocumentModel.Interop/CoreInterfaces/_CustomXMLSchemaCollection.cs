using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLSchemaCollection: InteropDictionary<string, CustomXMLSchema>
{
  public string NamespaceURI { get; }
}
