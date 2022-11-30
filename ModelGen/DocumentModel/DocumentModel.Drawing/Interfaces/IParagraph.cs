namespace DocumentModel.Drawing;

/// <summary>
/// Text Paragraphs.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.IParagraphProperties? ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.IRun? Run { get ; set; }
  
  public DocumentModel.Drawing.IBreak? Break { get ; set; }
  
  public DocumentModel.Drawing.IField? Field { get ; set; }
  
  public System.Boolean? TextMath { get ; set; }
  
  public DocumentModel.Drawing.IEndParagraphRunProperties? EndParagraphRunProperties { get ; set; }
  
}
