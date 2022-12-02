namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFieldExtension Class.
/// </summary>
public interface IPivotFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotField? PivotField { get ; set; }
  
}
