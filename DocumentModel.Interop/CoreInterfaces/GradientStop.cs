
namespace DocumentModel.Interop.Core;

public interface GradientStop: InteropObject
{
  ColorFormat Color { get; }
  float Position { get; set; }
  float Transparency { get; set; }
}