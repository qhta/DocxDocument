
namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMapping: InteropObject
{
  public string Prefix { get; }
  public string NamespaceURI { get; }
}
