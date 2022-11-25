namespace DocumentModel.Drawing;

/// <summary>
/// Text Paragraphs.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? ParagraphProperties { get ; set; }
  
}
