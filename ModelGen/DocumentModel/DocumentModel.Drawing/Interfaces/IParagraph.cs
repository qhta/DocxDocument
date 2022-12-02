namespace DocumentModel.Drawing;

/// <summary>
/// Text Paragraphs.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public IParagraphProperties? ParagraphProperties { get ; set; }
  
  public Collection<IRun>? Runs { get ; set; }
  
  public Collection<IBreak>? Breaks { get ; set; }
  
  public Collection<IField>? Fields { get ; set; }
  
  public Collection<Boolean>? TextMaths { get ; set; }
  
  public IEndParagraphRunProperties? EndParagraphRunProperties { get ; set; }
  
}
