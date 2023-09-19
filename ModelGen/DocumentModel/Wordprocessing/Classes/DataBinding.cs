namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the information that shall be used to establish a mapping between the nearest ancestor structured document tag and an XML element stored within a Custom XML Data part in the current WordprocessingML document.
/// </summary>
public partial class DataBinding
{
  
  /// <summary>
  ///   XML Namespace Prefix Mappings
  /// </summary>
  [SchemaAttr("w:prefixMappings")]
  public String? PrefixMappings { get; set; }
  
  
  /// <summary>
  ///   XPath
  /// </summary>
  [SchemaAttr("w:xpath")]
  public String? XPath { get; set; }
  
  
  /// <summary>
  ///   Custom XML Data Storage ID
  /// </summary>
  [SchemaAttr("w:storeItemID")]
  public String? StoreItemId { get; set; }
  
}
