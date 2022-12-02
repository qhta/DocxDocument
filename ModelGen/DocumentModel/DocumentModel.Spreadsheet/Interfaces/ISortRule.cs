namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortRule Class.
/// </summary>
public interface ISortRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// colId, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? ColId { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// DifferentialFormatType.
  /// </summary>
  public IDifferentialFormatType? DifferentialFormatType { get ; set; }
  
  public ISortCondition? SortCondition { get ; set; }
  
  public IRichSortCondition? RichSortCondition { get ; set; }
  
}
