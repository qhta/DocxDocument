namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Auto-Numbered Bullet.
/// </summary>
public class AutoNumberedBullet: ModelElement
{
  /// <summary>
  ///   Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeKind? Type { get; set; }

  /// <summary>
  ///   Start Numbering At
  /// </summary>
  public Int32? StartAt { get; set; }
}