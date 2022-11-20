namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public interface IDataBinding // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public string? PrefixMappings { get ; set; }
  
  /// <summary>
  /// XPath
  /// </summary>
  public string? XPath { get ; set; }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public string? StoreItemId { get ; set; }
  
}
