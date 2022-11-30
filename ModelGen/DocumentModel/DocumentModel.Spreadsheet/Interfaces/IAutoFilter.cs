namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Settings.
/// </summary>
public interface IAutoFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cell or Range Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IFilterColumn>? FilterColumns { get ; set; }
  
  public DocumentModel.Spreadsheet.ISortState? SortState { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
