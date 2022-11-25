namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Cell Properties.
/// </summary>
public interface IPreviousTableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableWidthType? TableCellWidth { get ; set; }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  public System.Int32? GridSpan { get ; set; }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? VerticalMerge { get ; set; }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellBorders? TableCellBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableCellFitText { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment { get ; set; }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? HideMark { get ; set; }
  
}
