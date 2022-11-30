namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public interface ITxPrTextBody // : DocumentModel.Office2016.Drawing.ChartDrawing.ITextBodyType
{
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParagraph>? Paragraphs { get ; set; }
  
}
