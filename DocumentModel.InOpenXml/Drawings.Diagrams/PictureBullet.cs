namespace DocumentModel.Drawings;

/// <summary>
///   Represents a picture bullet, which uses an image as a bullet in lists or text.
/// </summary>
[OpenXmlType(typeof(DXD.PictureBullet))]
/// <summary>
/// Represents the Picture Bullet.
/// </summary>
public class PictureBullet: ModelElement<DXD.PictureBullet>
{
  /// <summary>
  ///   Image used for the picture bullet.
  /// </summary>
  public Blip? Blip { get; set; }
}
