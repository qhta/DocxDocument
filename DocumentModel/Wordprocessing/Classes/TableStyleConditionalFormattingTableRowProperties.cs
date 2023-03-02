namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Style Conditional Formatting Table Row Properties.
/// </summary>
public record TableStyleConditionalFormattingTableRowProperties
{
  public Boolean? Hidden { get; set; }

  public Boolean? CantSplit { get; set; }

  public Boolean? TableHeader { get; set; }

  public TableWidthType? TableCellSpacing { get; set; }

  public TableRowAlignmentKind? TableJustification { get; set; }
}