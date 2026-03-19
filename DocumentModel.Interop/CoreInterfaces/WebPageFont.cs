
namespace DocumentModel.Interop.Core;

public interface WebPageFont: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string ProportionalFont { get; set; }
  float ProportionalFontSize { get; set; }
  string FixedWidthFont { get; set; }
  float FixedWidthFontSize { get; set; }
}