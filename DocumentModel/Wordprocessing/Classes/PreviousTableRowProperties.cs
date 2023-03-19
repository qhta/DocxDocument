namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Table Row Properties.
/// </summary>
public class PreviousTableRowProperties: ModelElement
{
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }

  public String? DivId { get; set; }

  public Int32? GridBefore { get; set; }

  public Int32? GridAfter { get; set; }

  public TableWidthType? WidthBeforeTableRow { get; set; }

  public TableWidthType? WidthAfterTableRow { get; set; }

  public TableRowHeight? TableRowHeight { get; set; }

  public Boolean? Hidden { get; set; }

  public Boolean? CantSplit { get; set; }

  public Boolean? TableHeader { get; set; }

  public TableWidthType? TableCellSpacing { get; set; }

  public TableRowAlignmentKind? TableJustification { get; set; }
}