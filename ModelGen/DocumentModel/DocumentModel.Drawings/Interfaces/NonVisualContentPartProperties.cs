namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface NonVisualContentPartProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
