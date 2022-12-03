namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnFilter Class.
/// </summary>
public interface ColumnFilter // : DocumentModel.BaseTypes.ModelElement
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
  
  public Collection<FilterColumn>? FilterColumns { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
