
namespace DocumentModel.Interop.Core;

public interface Adjustments: InteropObject
{
  int Count { get; }
  float this[int Index] { get; set; }
}