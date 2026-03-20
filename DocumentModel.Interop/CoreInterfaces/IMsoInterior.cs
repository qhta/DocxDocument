
namespace DocumentModel.Interop.Core;

public interface IMsoInterior
{
  object Color { get; set; }
  object ColorIndex { get; set; }
  object InvertIfNegative { get; set; }
  object Pattern { get; set; }
  object PatternColor { get; set; }
  object PatternColorIndex { get; set; }
}