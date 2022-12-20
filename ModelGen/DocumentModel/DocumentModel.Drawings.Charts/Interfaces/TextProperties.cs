namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public partial interface TextProperties
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get; set; }
  
}
