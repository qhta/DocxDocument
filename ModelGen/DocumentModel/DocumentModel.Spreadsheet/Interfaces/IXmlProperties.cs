namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column XML Properties.
/// </summary>
public interface IXmlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// XML Map Id
  /// </summary>
  public UInt32? MapId { get ; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public String? XPath { get ; set; }
  
  /// <summary>
  /// XML Data Type
  /// </summary>
  public XmlDataKind? XmlDataType { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
