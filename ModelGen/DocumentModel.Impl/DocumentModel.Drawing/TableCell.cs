namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITextBody))]
public class TableCell: ITableCell
{
  /// <summary>
  /// Row Span
  /// </summary>
  public int? RowSpan
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grid Span
  /// </summary>
  public int? GridSpan
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Merge
  /// </summary>
  public bool? HorizontalMerge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Merge
  /// </summary>
  public bool? VerticalMerge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawing.ITextBody? TextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public DocumentModel.Drawing.ITableCellProperties? TableCellProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
