namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public partial class TableStyleConditionalFormattingTableRowProperties
{
  public Boolean? Hidden { get; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? CantSplit { get; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableHeader { get; set; }
  
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get; set; }
  
}
