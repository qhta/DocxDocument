
namespace DocumentModel.Interop.Core;

public partial interface FillFormat
{
  public void Background();
  public void OneColorGradient(MsoGradientStyle Style, int Variant, float Degree);
  public void Patterned(MsoPatternType Pattern);
  public void PresetGradient(MsoGradientStyle Style, int Variant, MsoPresetGradientType PresetGradientType);
  public void PresetTextured(MsoPresetTexture PresetTexture);
  public void Solid();
  public void TwoColorGradient(MsoGradientStyle Style, int Variant);
  public void UserPicture(string PictureFile);
  public void UserTextured(string TextureFile);
}
