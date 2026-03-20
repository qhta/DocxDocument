using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLSchemaCollection: InteropObject, IEnumerable
{
  int Count { get; }
  CustomXMLSchema this[object Index] { get; }
  string NamespaceURI { get; }

  CustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);

  void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  bool Validate();
  new IEnumerator GetEnumerator();
}