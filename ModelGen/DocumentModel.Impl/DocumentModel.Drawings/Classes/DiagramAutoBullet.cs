namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public class DiagramAutoBulletImpl: ModelElementImpl, DiagramAutoBullet
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramAutoBulletImpl(): base() {}
  
  public DiagramAutoBulletImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public String? AutoBulletPrefix
  {
    get => (System.String?)OpenXmlElement?.AutoBulletPrefix?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AutoBulletPrefix = (System.String?)value;
    }
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public Boolean? LeadZeros
  {
    get => (System.Boolean?)OpenXmlElement?.LeadZeros?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeadZeros = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  public Boolean? NoBullet
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.NoBullet();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public DocumentModel.Drawings.AutoNumberedBullet? AutoNumberedBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public DocumentModel.Drawings.CharacterBullet? CharacterBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public DocumentModel.Drawings.PictureBullet? PictureBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
