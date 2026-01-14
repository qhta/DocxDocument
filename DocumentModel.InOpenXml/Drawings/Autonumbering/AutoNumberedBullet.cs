namespace DocumentModel.Drawings;

/// <summary>
/// Represents an auto-numbered bullet, specifying the numbering scheme and starting value for bullet lists.
/// </summary>
public class AutoNumberedBullet: ModelElement
{
  /// <summary>
  /// Bullet autonumbering type.
  /// </summary>
  public TextAutoNumberSchemeKind? Type { get; set; }

  /// <summary>
  /// Starting value for numbering.
  /// </summary>
  public Int32? StartAt { get; set; }
}