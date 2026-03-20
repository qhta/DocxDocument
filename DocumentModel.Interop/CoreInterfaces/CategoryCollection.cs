
namespace DocumentModel.Interop.Core;

public partial interface CategoryCollection
{
  public int Count { get; }
  public IMsoCategory this[object Index] { get; }
}
