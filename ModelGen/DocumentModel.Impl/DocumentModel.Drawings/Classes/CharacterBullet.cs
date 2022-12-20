namespace DocumentModel.Drawings;

/// <summary>
/// Character Bullet.
/// </summary>
public partial class CharacterBulletImpl: ModelElementImpl, CharacterBullet
{
  public DocumentFormat.OpenXml.Drawing.CharacterBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CharacterBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CharacterBulletImpl(): base() {}
  
  public CharacterBulletImpl(DocumentFormat.OpenXml.Drawing.CharacterBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Bullet Character
  /// </summary>
  public String? Char
  {
    get => (System.String?)OpenXmlElement?.Char?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Char = (System.String?)value;
    }
  }
  
}
