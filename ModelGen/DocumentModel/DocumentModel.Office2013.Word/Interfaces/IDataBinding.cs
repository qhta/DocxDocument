namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public interface IDataBinding // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public System.String? PrefixMappings { get ; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public System.String? XPath { get ; set; }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public System.String? StoreItemId { get ; set; }
  
}
