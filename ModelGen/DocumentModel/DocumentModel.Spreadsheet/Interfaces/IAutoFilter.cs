namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Settings.
/// </summary>
public interface IAutoFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cell or Range Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  public Collection<IFilterColumn>? FilterColumns { get ; set; }
  
  public ISortState? SortState { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
