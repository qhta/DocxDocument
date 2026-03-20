
namespace DocumentModel.Interop.Core;

public interface TextFrame: InteropObject
{
  float MarginBottom { get; set; }
  float MarginLeft { get; set; }
  float MarginRight { get; set; }
  float MarginTop { get; set; }
  MsoTextOrientation Orientation { get; set; }
}