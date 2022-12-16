namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public interface RichTextBody
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get ; set; }
  
}
