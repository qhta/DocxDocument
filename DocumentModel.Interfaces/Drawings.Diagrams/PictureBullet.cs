namespace DocumentModel.Drawings;

/// <summary>
///   Represents a picture bullet, which uses an image as a bullet in lists or text.
/// </summary>
public interface PictureBullet
{
  /// <summary>
  ///   Image used for the picture bullet.
  /// </summary>
  public Blip? Blip { get; set; }
}