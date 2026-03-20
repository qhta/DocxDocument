
namespace DocumentModel.Interop.Core;

public partial interface CustomXMLSchema: InteropObject
{
  public string Location { get; }
  public string NamespaceURI { get; }
}
