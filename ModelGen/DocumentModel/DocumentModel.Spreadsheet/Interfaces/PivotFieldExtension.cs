namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFieldExtension Class.
/// </summary>
public interface PivotFieldExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotField? PivotField { get ; set; }
  
}
