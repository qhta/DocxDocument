namespace DocumentModel.Word13;


/// <summary>
///   This element specifies the information used to establish a mapping between the parent structured document tag and an XML element stored within a Custom XML Data part in the current WordprocessingML document.
/// </summary>
public partial class DataBinding
{
  
  /// <summary>
  ///   XML Namespace Prefix Mappings
  /// </summary>
  public String? PrefixMappings { get; set; }
  
  
  /// <summary>
  ///   XPath
  /// </summary>
  public String? XPath { get; set; }
  
  
  /// <summary>
  ///   Custom XML Data Storage ID
  /// </summary>
  public String? StoreItemId { get; set; }
  
}
