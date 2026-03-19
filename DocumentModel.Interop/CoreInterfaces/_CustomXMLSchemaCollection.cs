using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CustomXMLSchemaCollection: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  CustomXMLSchema this[object Index] { get; }
  string NamespaceURI { get; }

  CustomXMLSchema Add
    (string NamespaceURI = "", string Alias = "", string FileName = "", bool InstallForAllUsers = false);

  void AddCollection(CustomXMLSchemaCollection SchemaCollection);
  bool Validate();
  new IEnumerator GetEnumerator();
}