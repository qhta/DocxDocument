
namespace DocumentModel.Interop.Core;

public interface CustomXMLSchema: InteropObject
{
  string Location { get; }
  string NamespaceURI { get; }
  void Delete();
  void Reload();
}