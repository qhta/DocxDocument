namespace DocumentModel.Math;


/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
