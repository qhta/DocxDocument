namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public interface TxPrTextBody
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get ; set; }
  
}
