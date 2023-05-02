namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Style Conditional Formatting Table Row Properties.
/// </summary>
public class TableStyleConditionalRowProperties: ModelElement
{
  public bool? Hidden { get; set; }

  public bool? CantSplit { get; set; }

  public bool? TableHeader { get; set; }

  public TableWidth? TableCellSpacing { get; set; }

  public TableRowAlignmentKind? TableJustification { get; set; }
}