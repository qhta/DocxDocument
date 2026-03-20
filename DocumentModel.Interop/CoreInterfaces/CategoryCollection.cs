
namespace DocumentModel.Interop.Core;

public interface CategoryCollection
{
  int Count { get; }
  IMsoCategory this[object Index] { get; }
}