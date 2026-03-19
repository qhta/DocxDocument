
namespace DocumentModel.Interop.Core;

public interface CategoryCollection
{
  object Parent { get; }
  int Count { get; }
  object Application { get; }
  int Creator { get; }
  IMsoCategory this[object Index] { get; }
}