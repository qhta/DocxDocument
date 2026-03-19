
namespace DocumentModel.Interop.Core;

public interface Adjustments: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  float this[int Index] { get; set; }
}