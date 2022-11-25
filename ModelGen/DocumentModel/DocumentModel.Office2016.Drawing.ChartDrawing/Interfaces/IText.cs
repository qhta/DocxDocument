namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface IText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextData.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITextBodyType? RichTextBody { get ; set; }
  
}
