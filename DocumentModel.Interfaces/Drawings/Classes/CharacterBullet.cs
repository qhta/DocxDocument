namespace DocumentModel.Drawings;

/// <summary>
///   Character Bullet.
/// </summary>
public interface CharacterBullet: IModelElement
{
  /// <summary>
  ///   Bullet Character
  /// </summary>
  public string? Char { get; set; }
}