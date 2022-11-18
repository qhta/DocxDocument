namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICellMerge))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IConditionalFormatStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGridSpan))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHorizontalMerge))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoWrap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellFitText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHideMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellWidth))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellPropertiesChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextDirection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICellInsertion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICellDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellVerticalAlignment))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalMerge))]
public interface ITableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IHorizontalMerge? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public IVerticalMerge? VerticalMerge { get ; set; }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellBorders? TableCellBorders { get ; set; }
  
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
  public ITextDirection? TextDirection { get ; set; }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  public ITableCellFitText? TableCellFitText { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public ITableCellVerticalAlignment? TableCellVerticalAlignment { get ; set; }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public IHideMark? HideMark { get ; set; }
  
}
