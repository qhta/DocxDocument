
namespace DocumentModel.Interop.Core;

public interface Axes
{
  public int Count { get; }
  public IMsoAxis Item { get; }
  public object _NewEnum { get; }
}
