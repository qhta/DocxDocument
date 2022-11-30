namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column XML Properties.
/// </summary>
public interface IXmlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// XML Map Id
  /// </summary>
  public System.UInt32? MapId { get ; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public System.String? XPath { get ; set; }
  
  /// <summary>
  /// XML Data Type
  /// </summary>
  public DocumentModel.Spreadsheet.XmlDataKind? XmlDataType { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
