
namespace DocumentModel.Interop.Core;

public interface ServerPolicy: InteropObject
{
  PolicyItem this[object Index] { get; }
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Statement { get; }
  int Count { get; }
  bool BlockPreview { get; }
}