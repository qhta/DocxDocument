
namespace DocumentModel.Interop.Core;

public interface SmartArtColor: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Category { get; }
}