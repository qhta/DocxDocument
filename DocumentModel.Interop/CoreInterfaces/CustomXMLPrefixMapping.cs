
namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMapping: InteropObject
{
  string Prefix { get; }
  string NamespaceURI { get; }
}