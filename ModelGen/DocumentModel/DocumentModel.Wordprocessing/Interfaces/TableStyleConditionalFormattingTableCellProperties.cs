namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public interface TableStyleConditionalFormattingTableCellProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public TableCellBorders? TableCellBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public OnOffOnlyKind? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get ; set; }
  
}
