
namespace DocumentModel.Interop.Core;

public interface CustomXMLSchema: InteropObject
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Location { get; }
  string NamespaceURI { get; }
  void Delete();
  void Reload();
}