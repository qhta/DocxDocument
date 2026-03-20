using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLSchemaCollection: InteropDictionary<string, CustomXMLSchema>
{
  public string NamespaceURI { get; }

  public CustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);

  public void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  public bool Validate();
}
