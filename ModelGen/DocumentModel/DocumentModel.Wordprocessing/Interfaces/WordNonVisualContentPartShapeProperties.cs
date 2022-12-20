namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
public partial interface WordNonVisualContentPartShapeProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get; set; }
  
}
