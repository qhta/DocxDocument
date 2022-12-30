namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public partial class Paragraph
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DocumentModel.Drawings.Run? Run { get; set; }
  
  public DocumentModel.Drawings.Break? Break { get; set; }
  
  public DocumentModel.Drawings.Field? Field { get; set; }
  
  public Boolean? TextMath { get; set; }
  
  public DocumentModel.Drawings.EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
  
}
