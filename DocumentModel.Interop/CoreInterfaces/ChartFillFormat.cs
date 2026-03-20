
namespace DocumentModel.Interop.Core;

public interface ChartFillFormat
{
  void OneColorGradient(int Style, int Variant, float Degree);
  void TwoColorGradient(int Style, int Variant);
  void PresetTextured(int PresetTexture);
  void Solid();
  void Patterned(int Pattern);
  void UserPicture(object PictureFile, object PictureFormat, object PictureStackUnit, object PicturePlacement);
  void UserTextured(string TextureFile);
  void PresetGradient(int Style, int Variant, int PresetGradientType);
  ChartColorFormat BackColor { get; }
  ChartColorFormat ForeColor { get; }
  int GradientColorType { get; }
  float GradientDegree { get; }
  int GradientStyle { get; }
  int GradientVariant { get; }
  int Pattern { get; }
  int PresetGradientType { get; }
  int PresetTexture { get; }
  string TextureName { get; }
  int TextureType { get; }
  int Type { get; }
  int Visible { get; set; }
}