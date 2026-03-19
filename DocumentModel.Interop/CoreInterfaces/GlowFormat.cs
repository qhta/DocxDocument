
namespace DocumentModel.Interop.Core;

public interface GlowFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  float Radius { get; set; }
  ColorFormat Color { get; }
  float Transparency { get; set; }
}