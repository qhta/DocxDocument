namespace DocumentModel.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public class AutoNumberedBulletImpl: ModelElementImpl, AutoNumberedBullet
{
  public DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AutoNumberedBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeKind? Type
  {
    get => (TextAutoNumberSchemeKind?)OpenXmlElement?.Type?.Value;
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
    get => (Int32?)OpenXmlElement?.StartAt?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartAt = (System.Int32?)value;
    }
  }
  
}
