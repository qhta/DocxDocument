namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXmlProperties))]
public class XmlCellProperties: IXmlCellProperties
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Unique Table Name
  /// </summary>
  public string? UniqueName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Column XML Properties.
  /// </summary>
  public IXmlProperties? XmlProperties
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
