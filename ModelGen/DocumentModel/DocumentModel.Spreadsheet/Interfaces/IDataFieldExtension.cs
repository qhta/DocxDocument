namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtension Class.
/// </summary>
public interface IDataFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IDataField? DataField { get ; set; }
  
}
