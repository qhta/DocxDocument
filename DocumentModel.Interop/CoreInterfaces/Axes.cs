
namespace DocumentModel.Interop.Core;

public interface Axes
{
  int Count { get; }
  IMsoAxis Item { get; }
  object _NewEnum { get; }
}