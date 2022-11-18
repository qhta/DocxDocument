namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Column Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IXmlColumnProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// Denormalized
  /// </summary>
  public bool? Denormalized { get ; set; }
  
  /// <summary>
  /// XML Data Type
  /// </summary>
  public XmlData? XmlDataType { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
