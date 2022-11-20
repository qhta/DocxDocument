namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXmlCellProperties))]
public class SingleXmlCell: ISingleXmlCell
{
  /// <summary>
  /// Table Id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection ID
  /// </summary>
  public uint? ConnectionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Properties.
  /// </summary>
  public IXmlCellProperties? XmlCellProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
