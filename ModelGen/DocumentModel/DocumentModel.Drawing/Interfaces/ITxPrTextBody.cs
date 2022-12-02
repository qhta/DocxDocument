namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public interface ITxPrTextBody // : DocumentModel.Drawing.ITextBodyType
{
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
}
