namespace DocumentModel.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public class AutoNumberedBulletImpl: ModelElement<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>, AutoNumberedBullet
{
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
  
}
