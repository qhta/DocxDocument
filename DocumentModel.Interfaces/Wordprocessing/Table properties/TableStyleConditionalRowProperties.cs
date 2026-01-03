namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Style Conditional Formatting Table Row Properties.
/// </summary>
public interface TableStyleConditionalRowProperties: IModelElement
{
  public bool? Hidden { get; set; }
  public bool? CantSplit { get; set; }
  public bool? TableHeader { get; set; }
  public TableWidth? TableCellSpacing { get; set; }
  public TableRowAlignmentKind? TableJustification { get; set; }
}