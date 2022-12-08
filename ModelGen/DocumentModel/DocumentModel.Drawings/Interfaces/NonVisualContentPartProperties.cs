namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface NonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties1? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
