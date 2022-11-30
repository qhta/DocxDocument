namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Properties.
/// </summary>
public interface ISingleXmlCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? CellReference { get ; set; }
  
  /// <summary>
  /// Connection ID
  /// </summary>
  public System.UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// Cell Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IXmlCellProperties? XmlCellProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
