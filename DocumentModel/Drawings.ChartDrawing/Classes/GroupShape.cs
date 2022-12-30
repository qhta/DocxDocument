namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public partial class GroupShape
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Shape? Shape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GroupShape? ChildGroupShape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GraphicFrame? GraphicFrame { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.ConnectionShape? ConnectionShape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Picture? Picture { get; set; }
  
}
