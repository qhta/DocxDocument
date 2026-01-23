namespace DocumentModel.Drawings;

/// <summary>
/// Represents a character bullet, including the bullet character and additional extension options.
/// </summary>
public class CharacterBullet: ModelElement<DXD.CharacterBullet>, IExtendableElement
{
  /// <summary>
  /// Bullet character.
  /// </summary>
  public string? Char { get; set; }

  /// <summary>
  /// List of extension elements.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}