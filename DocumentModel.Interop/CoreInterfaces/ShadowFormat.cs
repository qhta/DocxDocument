
namespace DocumentModel.Interop.Core;

public interface ShadowFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void IncrementOffsetX(float Increment);
  void IncrementOffsetY(float Increment);
  ColorFormat ForeColor { get; set; }
  MsoTriState Obscured { get; set; }
  float OffsetX { get; set; }
  float OffsetY { get; set; }
  float Transparency { get; set; }
  MsoShadowType Type { get; set; }
  MsoTriState Visible { get; set; }
  MsoShadowStyle Style { get; set; }
  float Blur { get; set; }
  float Size { get; set; }
  MsoTriState RotateWithShape { get; set; }
}