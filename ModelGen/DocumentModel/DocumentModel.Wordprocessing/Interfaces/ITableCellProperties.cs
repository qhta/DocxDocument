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
  public ITableCellWidth? TableCellWidth { get ; set; }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  public IGridSpan? GridSpan { get ; set; }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues>? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues>? VerticalMerge { get ; set; }
  
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
  public INoWrap? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues>? TextDirection { get ; set; }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  public ITableCellFitText? TableCellFitText { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues>? TableCellVerticalAlignment { get ; set; }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public IHideMark? HideMark { get ; set; }
  
}
