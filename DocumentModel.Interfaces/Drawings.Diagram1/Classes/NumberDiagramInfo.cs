namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public interface NumberDiagramInfo:
{
  /// <summary>
  ///   lvl
  /// </summary>
  public UInt32? Lvl { get; set; }
  /// <summary>
  ///   ptType
  /// </summary>
  public STorageType? PtType { get; set; }
  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  public DiagramAutoBullet? DiagramAutoBullet { get; set; }
}