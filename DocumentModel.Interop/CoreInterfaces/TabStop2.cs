
namespace DocumentModel.Interop.Core;

public interface TabStop2: InteropObject
{
  void Clear();
  float Position { get; set; }
  MsoTabStopType Type { get; set; }
}