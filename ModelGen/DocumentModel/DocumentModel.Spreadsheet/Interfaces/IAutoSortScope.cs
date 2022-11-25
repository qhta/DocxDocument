namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoSort Scope.
/// </summary>
public interface IAutoSortScope // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Auto Sort Scope.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
}
