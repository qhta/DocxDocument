namespace DocumentModel.Drawings;


/// <summary>
///   Text Paragraphs.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public DMD.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DMD.EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
  
}
