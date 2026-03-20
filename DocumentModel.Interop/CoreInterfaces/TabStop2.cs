
namespace DocumentModel.Interop.Core;

public partial interface TabStop2: InteropObject
{
  public float Position { get; set; }
  public MsoTabStopType Type { get; set; }
}
