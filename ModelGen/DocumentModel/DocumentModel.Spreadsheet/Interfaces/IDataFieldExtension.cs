namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtension Class.
/// </summary>
public interface IDataFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.IDataField? DataField { get ; set; }
  
}
