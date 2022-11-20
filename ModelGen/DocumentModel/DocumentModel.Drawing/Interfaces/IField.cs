namespace DocumentModel.Drawing;

/// <summary>
/// Text Field.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IText))]
public interface IField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field ID
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Field Type
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.IParagraphProperties? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawing.IText? Text { get ; set; }
  
}
