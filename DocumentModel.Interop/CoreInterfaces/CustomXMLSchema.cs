
namespace DocumentModel.Interop.Core;

public interface CustomXMLSchema: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Location { get; }
  string NamespaceURI { get; }
  void Delete();
  void Reload();
}