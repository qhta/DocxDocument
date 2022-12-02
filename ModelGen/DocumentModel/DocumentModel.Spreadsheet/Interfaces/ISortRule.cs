namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortRule Class.
/// </summary>
public interface ISortRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// colId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? ColId { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// DifferentialFormatType.
  /// </summary>
  public DocumentModel.Spreadsheet.IDifferentialFormatType? DifferentialFormatType { get ; set; }
  
  public DocumentModel.Spreadsheet.ISortCondition? SortCondition { get ; set; }
  
  public DocumentModel.Spreadsheet.IRichSortCondition? RichSortCondition { get ; set; }
  
}
