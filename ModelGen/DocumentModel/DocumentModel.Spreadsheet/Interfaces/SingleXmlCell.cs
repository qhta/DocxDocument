namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Properties.
/// </summary>
public interface SingleXmlCell // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Table Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? CellReference { get ; set; }
  
  /// <summary>
  /// Connection ID
  /// </summary>
  public UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// Cell Properties.
  /// </summary>
  public XmlCellProperties? XmlCellProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
