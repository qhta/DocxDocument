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
  
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public String? AutoBulletPrefix
  {
    get => (String?)OpenXmlElement?.AutoBulletPrefix?.Value;
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
    get => (Boolean?)OpenXmlElement?.LeadZeros?.Value;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.NoBullet();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public AutoNumberedBullet? AutoNumberedBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public CharacterBullet? CharacterBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public PictureBullet? PictureBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
