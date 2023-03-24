namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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