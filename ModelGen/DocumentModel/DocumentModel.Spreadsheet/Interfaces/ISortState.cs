namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort State for Auto Filter.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISortCondition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISortCondition))]
public interface ISortState // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sort by Columns
  /// </summary>
  public bool? ColumnSort { get ; set; }
  
  /// <summary>
  /// Case Sensitive
  /// </summary>
  public bool? CaseSensitive { get ; set; }
  
  /// <summary>
  /// Sort Method
  /// </summary>
  public SortMethodValues? SortMethod { get ; set; }
  
  /// <summary>
  /// Sort Range
  /// </summary>
  public string? Reference { get ; set; }
  
}
