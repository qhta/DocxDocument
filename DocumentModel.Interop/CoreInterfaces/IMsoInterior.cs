
namespace DocumentModel.Interop.Core;

public partial interface IMsoInterior
{
  public object Color { get; set; }
  public object ColorIndex { get; set; }
  public object InvertIfNegative { get; set; }
  public object Pattern { get; set; }
  public object PatternColor { get; set; }
  public object PatternColorIndex { get; set; }
}
