namespace DocumentModel.Drawings;
/// <summary>
///   Represents a picture bullet, which uses an image as a bullet in lists or text.
/// </summary>
[OpenXmlType(typeof(DXD.PictureBullet))]
[XmlRoot("PictureBullet", Namespace = "DocumentModel.Drawings")]
public partial class PictureBullet : ModelElement<DXD.PictureBullet>
{
 /// <summary>
 ///   Image used for the picture bullet.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PictureBullet.Blip))]
 public Blip? Blip { get => _Blip; set => UpdateField(ref _Blip, value, nameof(Blip)); }
 private Blip? _Blip;
}