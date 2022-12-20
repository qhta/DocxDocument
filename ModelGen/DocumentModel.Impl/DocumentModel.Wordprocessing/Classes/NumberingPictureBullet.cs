namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public partial class NumberingPictureBulletImpl: ModelElementImpl, NumberingPictureBullet
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.Int32?)OpenXmlElement?.NumberingPictureBulletId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberingPictureBulletId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public DocumentModel.Wordprocessing.PictureBulletBase? PictureBulletBase
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PictureBulletBaseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PictureBulletBaseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing? Drawing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
