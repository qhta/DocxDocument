namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public record NumberDiagramInfo
{
  /// <summary>
  ///   lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public UInt32? Lvl { get; set; }

  /// <summary>
  ///   ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public STorageType? PtType { get; set; }

  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  public DiagramAutoBullet? DiagramAutoBullet { get; set; }
}