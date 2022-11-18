namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column XML Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IXmlProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// XML Map Id
  /// </summary>
  public uint? MapId { get ; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public string? XPath { get ; set; }
  
  /// <summary>
  /// XML Data Type
  /// </summary>
  public XmlData? XmlDataType { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
