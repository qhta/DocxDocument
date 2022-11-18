namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoWrap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellVerticalAlignment))]
public interface ITableStyleConditionalFormattingTableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
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
  /// TableCellVerticalAlignment.
  /// </summary>
  public ITableCellVerticalAlignment? TableCellVerticalAlignment { get ; set; }
  
}
