
namespace DocumentModel.Interop.Core;

public interface CategoryCollection
{
  object Parent { get; }
  int Count { get; }
  IMsoCategory Item(object Index);
  object Application { get; }
  int Creator { get; }
  IMsoCategory this[object Index] { get; }
}