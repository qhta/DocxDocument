namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Column Properties.
/// </summary>
public interface IXmlColumnProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Denormalized
  /// </summary>
  public Boolean? Denormalized { get ; set; }
  
  /// <summary>
  /// XML Data Type
  /// </summary>
  public XmlDataKind? XmlDataType { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
