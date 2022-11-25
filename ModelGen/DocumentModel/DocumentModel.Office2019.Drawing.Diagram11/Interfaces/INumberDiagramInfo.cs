namespace DocumentModel.Office2019.Drawing.Diagram11;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public interface INumberDiagramInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public System.UInt32? Lvl { get ; set; }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Diagram11.STorageType? PtType { get ; set; }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Diagram11.IDiagramAutoBullet? DiagramAutoBullet { get ; set; }
  
}
