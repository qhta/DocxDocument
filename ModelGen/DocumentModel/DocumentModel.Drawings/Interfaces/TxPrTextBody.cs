namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public interface TxPrTextBody
{
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
}
