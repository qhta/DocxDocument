namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TxPrTextBody Class.
/// </summary>
public class TxPrTextBody: ModelElement
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}