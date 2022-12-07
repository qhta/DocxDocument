namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public interface Paragraph
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get ; set; }
  
  public EndParagraphRunProperties? EndParagraphRunProperties { get ; set; }
  
}
