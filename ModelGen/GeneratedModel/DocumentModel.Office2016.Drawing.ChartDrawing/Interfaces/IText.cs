namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Text Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IRichTextBody))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ITextData))]
public interface IText // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextData.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITextData? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public IRichTextBody? RichTextBody { get ; set; }
  
}
