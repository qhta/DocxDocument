namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Group Shape.
/// </summary>
public partial class GroupShape
{
  
  /// <summary>
  ///   Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? GroupShapeProperties { get; set; }
  
}
