namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFieldExtension Class.
/// </summary>
public interface IPivotFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Excel.IPivotField? PivotField { get ; set; }
  
}
