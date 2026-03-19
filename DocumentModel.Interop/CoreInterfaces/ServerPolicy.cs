
namespace DocumentModel.Interop.Core;

public interface ServerPolicy: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  PolicyItem this[object Index] { get; }
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Statement { get; }
  int Count { get; }
  bool BlockPreview { get; }
  object Parent { get; }
}