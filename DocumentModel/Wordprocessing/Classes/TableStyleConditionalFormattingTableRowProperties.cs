namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Style Conditional Formatting Table Row Properties.
/// </summary>
public class TableStyleConditionalFormattingTableRowProperties: ModelElement
{
  public Boolean? Hidden { get; set; }

  public Boolean? CantSplit { get; set; }

  public Boolean? TableHeader { get; set; }

  public TableWidthType? TableCellSpacing { get; set; }

  public TableRowAlignmentKind? TableJustification { get; set; }
}