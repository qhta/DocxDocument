
namespace DocumentModel.Interop.Core;

public interface GlowFormat: InteropObject
{
  float Radius { get; set; }
  ColorFormat Color { get; }
  float Transparency { get; set; }
}