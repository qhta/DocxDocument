namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Settings.
/// </summary>
public interface AutoFilter // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Cell or Range Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  public Collection<FilterColumn>? FilterColumns { get ; set; }
  
  public SortState? SortState { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
