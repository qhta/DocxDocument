namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public class NumberDiagramInfo
{
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public STorageType? PtType
  {
    get;
    set;
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DiagramAutoBullet? DiagramAutoBullet
  {
    get;
    set;
  }
  
}
