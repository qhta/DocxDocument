
namespace DocumentModel.Interop.Core;

public partial interface ChartFillFormat
{
  public ChartColorFormat BackColor { get; }
  public ChartColorFormat ForeColor { get; }
  public int GradientColorType { get; }
  public float GradientDegree { get; }
  public int GradientStyle { get; }
  public int GradientVariant { get; }
  public int Pattern { get; }
  public int PresetGradientType { get; }
  public int PresetTexture { get; }
  public string TextureName { get; }
  public int TextureType { get; }
  public int Type { get; }
  public int Visible { get; set; }
}
