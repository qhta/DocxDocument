
namespace DocumentModel.Interop.Core;

public partial interface FillFormat: InteropObject
{
  public ColorFormat BackColor { get; set; }
  public ColorFormat ForeColor { get; set; }
  public MsoGradientColorType GradientColorType { get; }
  public float GradientDegree { get; }
  public MsoGradientStyle GradientStyle { get; }
  public int GradientVariant { get; }
  public MsoPatternType Pattern { get; }
  public MsoPresetGradientType PresetGradientType { get; }
  public MsoPresetTexture PresetTexture { get; }
  public string TextureName { get; }
  public MsoTextureType TextureType { get; }
  public float Transparency { get; set; }
  public MsoFillType Type { get; }
  public MsoTriState Visible { get; set; }
  public GradientStops GradientStops { get; }
  public float TextureOffsetX { get; set; }
  public float TextureOffsetY { get; set; }
  public MsoTextureAlignment TextureAlignment { get; set; }
  public float TextureHorizontalScale { get; set; }
  public float TextureVerticalScale { get; set; }
  public MsoTriState TextureTile { get; set; }
  public MsoTriState RotateWithObject { get; set; }
  public PictureEffects PictureEffects { get; }
  public float GradientAngle { get; set; }
}
