namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Properties.
/// </summary>
public interface TableCellProperties
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public ConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public TableWidthType? TableCellWidth { get ; set; }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  public MergedCellKind? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public MergedCellKind? VerticalMerge { get ; set; }
  
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
  /// TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  public OnOffOnlyKind? TableCellFitText { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get ; set; }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public OnOffOnlyKind? HideMark { get ; set; }
  
  public CellMerge? CellMerge { get ; set; }
  
  public TableCellPropertiesChange? TableCellPropertiesChange { get ; set; }
  
}
