
namespace DocumentModel.Interop.Core;

public interface CustomXMLPrefixMapping: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Prefix { get; }
  string NamespaceURI { get; }
}