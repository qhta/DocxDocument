namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Column Properties.
/// </summary>
public interface XmlColumnProperties // : DocumentModel.BaseTypes.ModelElement
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
  public ExtensionList? ExtensionList { get ; set; }
  
}
