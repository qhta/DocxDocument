namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filters.
/// </summary>
public interface ICustomFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// And
  /// </summary>
  public System.Boolean? And { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICustomFilter>? CustomFilters { get ; set; }
  
}
