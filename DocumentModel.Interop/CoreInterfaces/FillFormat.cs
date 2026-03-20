
namespace DocumentModel.Interop.Core;

public interface FillFormat: InteropObject
{
  void Background();
  void OneColorGradient(MsoGradientStyle Style, int Variant, float Degree);
  void Patterned(MsoPatternType Pattern);
  void PresetGradient(MsoGradientStyle Style, int Variant, MsoPresetGradientType PresetGradientType);
  void PresetTextured(MsoPresetTexture PresetTexture);
  void Solid();
  void TwoColorGradient(MsoGradientStyle Style, int Variant);
  void UserPicture(string PictureFile);
  void UserTextured(string TextureFile);
  ColorFormat BackColor { get; set; }
  ColorFormat ForeColor { get; set; }
  MsoGradientColorType GradientColorType { get; }
  float GradientDegree { get; }
  MsoGradientStyle GradientStyle { get; }
  int GradientVariant { get; }
  MsoPatternType Pattern { get; }
  MsoPresetGradientType PresetGradientType { get; }
  MsoPresetTexture PresetTexture { get; }
  string TextureName { get; }
  MsoTextureType TextureType { get; }
  float Transparency { get; set; }
  MsoFillType Type { get; }
  MsoTriState Visible { get; set; }
  GradientStops GradientStops { get; }
  float TextureOffsetX { get; set; }
  float TextureOffsetY { get; set; }
  MsoTextureAlignment TextureAlignment { get; set; }
  float TextureHorizontalScale { get; set; }
  float TextureVerticalScale { get; set; }
  MsoTriState TextureTile { get; set; }
  MsoTriState RotateWithObject { get; set; }
  PictureEffects PictureEffects { get; }
  float GradientAngle { get; set; }
}