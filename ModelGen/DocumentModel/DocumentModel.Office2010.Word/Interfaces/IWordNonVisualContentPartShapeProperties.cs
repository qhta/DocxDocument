namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
public interface IWordNonVisualContentPartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
