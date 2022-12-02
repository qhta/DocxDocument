namespace DocumentModel.Drawing;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.IPicture? Picture { get ; set; }
  
}
