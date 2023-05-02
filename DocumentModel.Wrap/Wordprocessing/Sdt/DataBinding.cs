namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataBinding Class.
/// </summary>
public class DataBinding: ModelElement
{
  /// <summary>
  ///   XML Namespace Prefix Mappings
  /// </summary>
  public string? PrefixMappings { get; set; }

  /// <summary>
  ///   XPath
  /// </summary>
  public string? XPath { get; set; }

  /// <summary>
  ///   Custom XML Data Storage ID
  /// </summary>
  public string? StoreItemId { get; set; }
}