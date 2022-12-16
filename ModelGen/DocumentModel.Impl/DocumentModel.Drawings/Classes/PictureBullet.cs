namespace DocumentModel.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public class PictureBulletImpl: ModelElementImpl, PictureBullet
{
  public DocumentFormat.OpenXml.Drawing.PictureBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PictureBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureBulletImpl(): base() {}
  
  public PictureBulletImpl(DocumentFormat.OpenXml.Drawing.PictureBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawings.Blip? Blip
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
        if (item != null)
          return new DocumentModel.Drawings.BlipImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BlipImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
