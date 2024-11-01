namespace DocumentModel.Drawings.Diagram1;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public class NumberDiagramInfo: ModelElement
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