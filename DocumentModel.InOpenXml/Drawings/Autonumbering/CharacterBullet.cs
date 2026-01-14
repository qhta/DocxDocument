namespace DocumentModel.Drawings;

/// <summary>
/// Represents a character bullet, including the bullet character and additional extension options.
/// </summary>
public interface CharacterBullet: IExtendableElement
{
  /// <summary>
  /// Bullet character.
  /// </summary>
  public string? Char { get; set; }
}