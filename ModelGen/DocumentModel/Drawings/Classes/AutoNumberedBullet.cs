namespace DocumentModel.Drawings;


/// <summary>
///   Auto-Numbered Bullet.
/// </summary>
public partial class AutoNumberedBullet
{
  
  /// <summary>
  ///   Bullet Autonumbering Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Drawings.TextAutoNumberSchemeValues? Type { get; set; }
  
  
  /// <summary>
  ///   Start Numbering At
  /// </summary>
  [SchemaAttr("startAt")]
  public Int32? StartAt { get; set; }
  
}
