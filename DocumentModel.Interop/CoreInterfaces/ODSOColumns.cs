
namespace DocumentModel.Interop.Core;

public interface ODSOColumns: InteropObject
{
  public int Count { get; }
  public object Item(object varIndex);
}
