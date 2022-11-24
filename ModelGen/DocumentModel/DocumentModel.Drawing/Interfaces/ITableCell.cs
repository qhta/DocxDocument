namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell.
/// </summary>
public interface ITableCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Row Span
  /// </summary>
  public Int32? RowSpan { get ; set; }
  
  /// <summary>
  /// Grid Span
  /// </summary>
  public Int32? GridSpan { get ; set; }
  
  /// <summary>
  /// Horizontal Merge
  /// </summary>
  public Boolean? HorizontalMerge { get ; set; }
  
  /// <summary>
  /// Vertical Merge
  /// </summary>
  public Boolean? VerticalMerge { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public ITableCellProperties? TableCellProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
