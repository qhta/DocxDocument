
namespace DocumentModel.Interop.Core;

public interface CategoryCollection
{
  public int Count { get; }
  public IMsoCategory this[object Index] { get; }
}
