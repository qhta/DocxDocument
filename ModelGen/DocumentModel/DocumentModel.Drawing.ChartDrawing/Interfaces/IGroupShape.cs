namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IPicture? Picture { get ; set; }
  
}
