namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NonVisualContentPartProperties Class.
/// </summary>
public class NonVisualContentPartProperties: ModelElement
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  /// <summary>
  ///   NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get; set; }
}