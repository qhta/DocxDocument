namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public interface Paragraph // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get ; set; }
  
  public Collection<Run>? Runs { get ; set; }
  
  public Collection<Break>? Breaks { get ; set; }
  
  public Collection<Field>? Fields { get ; set; }
  
  public Collection<Boolean>? TextMaths { get ; set; }
  
  public EndParagraphRunProperties? EndParagraphRunProperties { get ; set; }
  
}
