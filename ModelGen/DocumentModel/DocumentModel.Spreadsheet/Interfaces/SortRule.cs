namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortRule Class.
/// </summary>
public interface SortRule // : DocumentModel.BaseTypes.ModelElement
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
  public DifferentialFormatType? DifferentialFormatType { get ; set; }
  
  public SortCondition? SortCondition { get ; set; }
  
  public RichSortCondition? RichSortCondition { get ; set; }
  
}
