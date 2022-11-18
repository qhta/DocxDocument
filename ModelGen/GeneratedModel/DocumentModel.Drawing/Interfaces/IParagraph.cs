namespace DocumentModel.Drawing;

/// <summary>
/// Text Paragraphs.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRun))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEndParagraphRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IField))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBreak))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ITextMath))]
public interface IParagraph // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.IParagraphProperties? ParagraphProperties { get ; set; }
  
}
