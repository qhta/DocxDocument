namespace DocumentModel.Drawings;


/// <summary>
///   Text Paragraphs.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DocumentModel.Drawings.EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
