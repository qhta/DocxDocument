
namespace DocumentModel.Interop.Core;

public interface SmartArtColor: InteropObject
{
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Category { get; }
}