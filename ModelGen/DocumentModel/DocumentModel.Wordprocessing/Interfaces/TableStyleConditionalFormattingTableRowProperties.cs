namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public interface TableStyleConditionalFormattingTableRowProperties
{
  public Boolean? Hidden { get ; set; }
  
  public OnOffOnlyKind? CantSplit { get ; set; }
  
  public OnOffOnlyKind? TableHeader { get ; set; }
  
  public TableWidthType? TableCellSpacing { get ; set; }
  
  public TableRowAlignmentKind? TableJustification { get ; set; }
  
}
