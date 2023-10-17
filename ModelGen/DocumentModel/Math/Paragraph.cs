namespace DocumentModel.Math;


/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  public DocumentModel.Math.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
