namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Row Properties.
/// </summary>
public partial interface PreviousTableRowProperties
{
  public DocumentModel.Wordprocessing.ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
  
  public String? DivId { get; set; }
  
  public Int32? GridBefore { get; set; }
  
  public Int32? GridAfter { get; set; }
  
  public DocumentModel.Wordprocessing.TableWidthType? WidthBeforeTableRow { get; set; }
  
  public DocumentModel.Wordprocessing.TableWidthType? WidthAfterTableRow { get; set; }
  
  public DocumentModel.Wordprocessing.TableRowHeight? TableRowHeight { get; set; }
  
  public Boolean? Hidden { get; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? CantSplit { get; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableHeader { get; set; }
  
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get; set; }
  
}
