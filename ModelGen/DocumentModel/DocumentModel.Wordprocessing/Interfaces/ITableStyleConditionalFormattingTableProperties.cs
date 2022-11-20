namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMarginDefault))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableIndentation))]
public interface ITableStyleConditionalFormattingTableProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableJustification.
  /// </summary>
  public ITableJustification? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public ITableCellSpacing? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
}
