
namespace DocumentModel.Interop.Core;

public interface WebPageFont: InteropObject
{
  string ProportionalFont { get; set; }
  float ProportionalFontSize { get; set; }
  string FixedWidthFont { get; set; }
  float FixedWidthFontSize { get; set; }
}