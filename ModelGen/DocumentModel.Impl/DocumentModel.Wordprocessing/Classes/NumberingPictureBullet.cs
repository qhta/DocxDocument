namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public class NumberingPictureBulletImpl: ModelElementImpl, NumberingPictureBullet
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public Int32? NumberingPictureBulletId
  {
    get;
    set;
  }
  
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
