
namespace DocumentModel.Interop.Core;

public interface SmartArtLayout: InteropObject
{
  public string Id { get; }
  public string Name { get; }
  public string Description { get; }
  public string Category { get; }
}
