namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public partial interface DataBinding3
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public String? PrefixMappings { get; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public String? XPath { get; set; }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public String? StoreItemId { get; set; }
  
}
