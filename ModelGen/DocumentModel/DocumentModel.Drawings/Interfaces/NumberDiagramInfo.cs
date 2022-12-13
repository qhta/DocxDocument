namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public interface NumberDiagramInfo
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public UInt32? Lvl { get ; set; }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.Drawings.STorageType? PtType { get ; set; }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DocumentModel.Drawings.DiagramAutoBullet? DiagramAutoBullet { get ; set; }
  
}
