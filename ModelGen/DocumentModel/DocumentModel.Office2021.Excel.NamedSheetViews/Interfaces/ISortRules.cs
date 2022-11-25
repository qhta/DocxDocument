namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the SortRules Class.
/// </summary>
public interface ISortRules // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sortMethod, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SortMethodKind? SortMethod { get ; set; }
  
  /// <summary>
  /// caseSensitive, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Boolean? CaseSensitive { get ; set; }
  
}
