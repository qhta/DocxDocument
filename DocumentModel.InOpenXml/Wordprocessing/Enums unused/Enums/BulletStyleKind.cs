namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the bullet style for bulleted lists.
/// </summary>
[OpenXmlNotMapped]
public enum BulletStyleKind
{
  /// <summary>Solid round bullet</summary>
  Bullet = 0,
  /// <summary>Open circle bullet</summary>
  Circle = 1,
  /// <summary>Solid square bullet</summary>
  Square = 2,
  /// <summary>Diamond bullet</summary>
  Diamond = 3,
  /// <summary>Arrow bullet</summary>
  Arrow = 4,
  /// <summary>Check mark bullet</summary>
  Check = 5
}