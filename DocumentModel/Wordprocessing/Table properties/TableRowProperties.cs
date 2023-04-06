namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Row Properties.
/// </summary>
public class TableRowProperties: ModelElement
{
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }

  public String? DivId { get; set; }

  public Int32? GridBefore { get; set; }

  public Int32? GridAfter { get; set; }

  public TableWidth? WidthBeforeTableRow { get; set; }

  public TableWidth? WidthAfterTableRow { get; set; }

  public TableRowHeight? TableRowHeight { get; set; }

  public Boolean? Hidden { get; set; }

  public Boolean? CantSplit { get; set; }

  public Boolean? TableHeader { get; set; }

  public TableWidth? TableCellSpacing { get; set; }

  public TableRowAlignmentKind? TableJustification { get; set; }

  public TrackChangeType? Inserted { get; set; }

  public TrackChangeType? Deleted { get; set; }

  public TableRowPropertiesChange? TableRowPropertiesChange { get; set; }

  public TrackChangeType2? ConflictInsertion { get; set; }

  public TrackChangeType2? ConflictDeletion { get; set; }
}