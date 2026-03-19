
namespace DocumentModel.Interop.Core;

public interface TabStop2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void Clear();
  float Position { get; set; }
  MsoTabStopType Type { get; set; }
}