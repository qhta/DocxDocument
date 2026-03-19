
namespace DocumentModel.Interop.Core;

public interface TextFrame: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  float MarginBottom { get; set; }
  float MarginLeft { get; set; }
  float MarginRight { get; set; }
  float MarginTop { get; set; }
  MsoTextOrientation Orientation { get; set; }
}