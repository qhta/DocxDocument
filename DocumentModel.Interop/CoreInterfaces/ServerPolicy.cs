
namespace DocumentModel.Interop.Core;

public interface ServerPolicy: InteropObject
{
  public PolicyItem this[object Index] { get; }
  public string Id { get; }
  public string Name { get; }
  public string Description { get; }
  public string Statement { get; }
  public int Count { get; }
  public bool BlockPreview { get; }
}
