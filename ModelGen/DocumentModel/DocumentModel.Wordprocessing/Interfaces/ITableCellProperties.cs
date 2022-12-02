namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Properties.
/// </summary>
public interface ITableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public ITableWidthType? TableCellWidth { get ; set; }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  public Int32? GridSpan { get ; set; }
  
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
  public ITableCellBorders? TableCellBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public OnOffOnlyKind? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public ITableCellMargin? TableCellMargin { get ; set; }
  
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
  
  public ITrackChangeType? CellInsertion { get ; set; }
  
  public ITrackChangeType? CellDeletion { get ; set; }
  
  public ICellMerge? CellMerge { get ; set; }
  
  public ITableCellPropertiesChange? TableCellPropertiesChange { get ; set; }
  
}
