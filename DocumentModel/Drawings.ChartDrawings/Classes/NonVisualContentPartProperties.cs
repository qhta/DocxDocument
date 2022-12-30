namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public partial class NonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get; set; }
  
}
