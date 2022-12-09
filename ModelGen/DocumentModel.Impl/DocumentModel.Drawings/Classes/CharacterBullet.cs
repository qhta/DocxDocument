namespace DocumentModel.Drawings;

/// <summary>
/// Character Bullet.
/// </summary>
public class CharacterBulletImpl: ModelElementImpl, CharacterBullet
{
  public DocumentFormat.OpenXml.Drawing.CharacterBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CharacterBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Bullet Character
  /// </summary>
  public String? Char
  {
    get => (String?)OpenXmlElement?.Char?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Char = (System.String?)value;
    }
  }
  
}
