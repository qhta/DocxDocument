namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public partial interface TxPrTextBody
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get; set; }
  
}
