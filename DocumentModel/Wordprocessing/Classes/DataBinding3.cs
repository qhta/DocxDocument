namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataBinding Class.
/// </summary>
public class DataBinding3: ModelElement
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