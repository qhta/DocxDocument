
namespace DocumentModel.Interop.Core;

public interface TabStop2: InteropObject
{
  public void Clear();
  public float Position { get; set; }
  public MsoTabStopType Type { get; set; }
}
