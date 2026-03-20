
namespace DocumentModel.Interop.Core;

public interface ShadowFormat: InteropObject
{
  public void IncrementOffsetX(float Increment);
  public void IncrementOffsetY(float Increment);
  public ColorFormat ForeColor { get; set; }
  public MsoTriState Obscured { get; set; }
  public float OffsetX { get; set; }
  public float OffsetY { get; set; }
  public float Transparency { get; set; }
  public MsoShadowType Type { get; set; }
  public MsoTriState Visible { get; set; }
  public MsoShadowStyle Style { get; set; }
  public float Blur { get; set; }
  public float Size { get; set; }
  public MsoTriState RotateWithShape { get; set; }
}
