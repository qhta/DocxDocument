namespace DocumentModel.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public partial class AutoNumberedBulletImpl: ModelElementImpl, AutoNumberedBullet
{
  public DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AutoNumberedBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AutoNumberedBulletImpl(): base() {}
  
  public AutoNumberedBulletImpl(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public DocumentModel.Drawings.TextAutoNumberSchemeKind? Type
  {
    get => (DocumentModel.Drawings.TextAutoNumberSchemeKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues?)value;
    }
  }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public Int32? StartAt
  {
    get => (System.Int32?)OpenXmlElement?.StartAt?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartAt = (System.Int32?)value;
    }
  }
  
}
