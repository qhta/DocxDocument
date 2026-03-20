
namespace DocumentModel.Interop.Core;

public interface CustomXMLSchema: InteropObject
{
  public string Location { get; }
  public string NamespaceURI { get; }
  public void Delete();
  public void Reload();
}
