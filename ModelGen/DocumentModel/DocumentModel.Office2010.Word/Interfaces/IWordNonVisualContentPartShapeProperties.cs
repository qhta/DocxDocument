namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
public interface IWordNonVisualContentPartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
