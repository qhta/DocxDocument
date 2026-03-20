using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLSchemaCollection
{
  public CustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);
  public void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  public bool Validate();
}
