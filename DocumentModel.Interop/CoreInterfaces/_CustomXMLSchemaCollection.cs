using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLSchemaCollection: InteropDictionary<string, CustomXMLSchema>
{
  string NamespaceURI { get; }

  CustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);

  void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  bool Validate();
}