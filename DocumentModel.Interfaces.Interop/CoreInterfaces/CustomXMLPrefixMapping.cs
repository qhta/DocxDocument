
namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMapping: InteropObject
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Prefix { get; }
  string NamespaceURI { get; }
}