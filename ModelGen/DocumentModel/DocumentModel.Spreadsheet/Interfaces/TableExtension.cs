namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableExtension Class.
/// </summary>
public interface TableExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public Table? Table { get ; set; }
  
}
