namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell.
/// </summary>
public interface ITableCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Row Span
  /// </summary>
  public System.Int32? RowSpan { get ; set; }
  
  /// <summary>
  /// Grid Span
  /// </summary>
  public System.Int32? GridSpan { get ; set; }
  
  /// <summary>
  /// Horizontal Merge
  /// </summary>
  public System.Boolean? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// Vertical Merge
  /// </summary>
  public System.Boolean? VerticalMerge { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawing.ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public DocumentModel.Drawing.ITableCellProperties? TableCellProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
