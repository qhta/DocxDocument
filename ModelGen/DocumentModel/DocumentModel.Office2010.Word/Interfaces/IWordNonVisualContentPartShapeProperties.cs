namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INonVisualInkContentPartProperties))]
public interface IWordNonVisualContentPartShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
