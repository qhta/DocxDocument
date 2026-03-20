
namespace DocumentModel.Interop.Core;

public partial interface PictureFormat: InteropObject
{
  public float Brightness { get; set; }
  public MsoPictureColorType ColorType { get; set; }
  public float Contrast { get; set; }
  public float CropBottom { get; set; }
  public float CropLeft { get; set; }
  public float CropRight { get; set; }
  public float CropTop { get; set; }
  public int TransparencyColor { get; set; }
  public MsoTriState TransparentBackground { get; set; }
  public Crop Crop { get; }
}
