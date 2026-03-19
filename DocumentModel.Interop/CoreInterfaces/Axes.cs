
namespace DocumentModel.Interop.Core;

public interface Axes
{
  int Count { get; }
  IMsoAxis Item { get; }
  object _NewEnum { get; }
  object Application { get; }
  int Creator { get; }
  object Parent { get; }
}