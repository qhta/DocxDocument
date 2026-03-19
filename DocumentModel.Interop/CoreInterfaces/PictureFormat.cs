
namespace DocumentModel.Interop.Core;

public interface PictureFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void IncrementBrightness(float Increment);
  void IncrementContrast(float Increment);
  float Brightness { get; set; }
  MsoPictureColorType ColorType { get; set; }
  float Contrast { get; set; }
  float CropBottom { get; set; }
  float CropLeft { get; set; }
  float CropRight { get; set; }
  float CropTop { get; set; }
  int TransparencyColor { get; set; }
  MsoTriState TransparentBackground { get; set; }
  Crop Crop { get; }
}