
namespace DocumentModel.Interop.Core;

public interface SmartArtLayout: InteropObject
{
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Category { get; }
}