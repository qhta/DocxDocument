namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface NonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
