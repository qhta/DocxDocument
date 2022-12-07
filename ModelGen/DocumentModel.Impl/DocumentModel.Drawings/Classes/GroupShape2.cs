namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape.
/// </summary>
public class GroupShape2Impl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>, GroupShape2
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties2? GroupShapeProperties
  {
    get;
    set;
  }
  
}
