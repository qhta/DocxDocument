namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public class NumberingPictureBulletImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>, NumberingPictureBullet
{
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public PictureBulletBase? PictureBulletBase
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public Drawing? Drawing
  {
    get;
    set;
  }
  
}
