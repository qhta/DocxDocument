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
  
  public NumberingPictureBulletImpl(): base() {}
  
  public NumberingPictureBulletImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public Int32? NumberingPictureBulletId
  {
    get => (Int32?)OpenXmlElement?.NumberingPictureBulletId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberingPictureBulletId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public PictureBulletBase? PictureBulletBase
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public Drawing? Drawing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
