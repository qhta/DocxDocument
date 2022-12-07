namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface NonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties3? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
