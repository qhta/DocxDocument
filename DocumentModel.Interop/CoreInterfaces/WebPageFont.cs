
namespace DocumentModel.Interop.Core;

public interface WebPageFont: InteropObject
{
  public string ProportionalFont { get; set; }
  public float ProportionalFontSize { get; set; }
  public string FixedWidthFont { get; set; }
  public float FixedWidthFontSize { get; set; }
}
