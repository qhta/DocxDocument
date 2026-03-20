
namespace DocumentModel.Interop.Core;

public partial interface CustomXMLPrefixMapping: InteropObject
{
  public string Prefix { get; }
  public string NamespaceURI { get; }
}
