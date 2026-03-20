
namespace DocumentModel.Interop.Core;

public interface ChartFillFormat
{
  public void OneColorGradient(int Style, int Variant, float Degree);
  public void TwoColorGradient(int Style, int Variant);
  public void PresetTextured(int PresetTexture);
  public void Solid();
  public void Patterned(int Pattern);
  public void UserPicture(object PictureFile, object PictureFormat, object PictureStackUnit, object PicturePlacement);
  public void UserTextured(string TextureFile);
  public void PresetGradient(int Style, int Variant, int PresetGradientType);
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
