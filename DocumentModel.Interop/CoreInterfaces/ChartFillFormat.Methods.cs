
namespace DocumentModel.Interop.Core;

public partial interface ChartFillFormat
{
  public void OneColorGradient(int Style, int Variant, float Degree);
  public void TwoColorGradient(int Style, int Variant);
  public void PresetTextured(int PresetTexture);
  public void Solid();
  public void Patterned(int Pattern);
  public void UserPicture(object PictureFile, object PictureFormat, object PictureStackUnit, object PicturePlacement);
  public void UserTextured(string TextureFile);
  public void PresetGradient(int Style, int Variant, int PresetGradientType);
}
