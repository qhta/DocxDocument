namespace DocumentModel.Office2019.Drawing.Diagram11;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Diagram11.IDiagramAutoBullet))]
public interface INumberDiagramInfo // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? Lvl { get ; set; }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public STorageType? PtType { get ; set; }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public IDiagramAutoBullet? DiagramAutoBullet { get ; set; }
  
}
