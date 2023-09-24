namespace DocumentModel.Math;


/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
