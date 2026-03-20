using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLSchemaCollection: InteropDictionary<string, CustomXMLSchema>
{
  public string NamespaceURI { get; }

  CustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);

  public void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  public bool Validate();
}
