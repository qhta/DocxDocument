
namespace DocumentModel.Interop.Core;

public interface Adjustments: InteropObject
{
  public int Count { get; }
  public float this[int Index] { get; set; }
}
