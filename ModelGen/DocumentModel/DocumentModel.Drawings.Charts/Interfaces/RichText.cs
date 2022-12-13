namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Rich Text.
/// </summary>
public interface RichText
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get ; set; }
  
}
