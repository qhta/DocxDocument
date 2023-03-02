namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
public record WordNonVisualContentPartShapeProperties
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