
namespace DocumentModel.Interop.Core;

public interface GradientStop: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  ColorFormat Color { get; }
  float Position { get; set; }
  float Transparency { get; set; }
}