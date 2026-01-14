namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the data binding configuration for a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides properties for XML namespace prefix mappings, XPath expressions, and custom XML data storage IDs, enabling advanced binding of SDT content to XML data sources.
/// </summary>
public interface SdtDataBinding
{
  /// <summary>
  /// XML namespace prefix mappings, specifying the prefixes used in XPath expressions for XML data binding.
  /// </summary>
  public string? PrefixMappings { get; set; }

  /// <summary>
  /// XPath expression used to locate the XML element for data binding.
  /// </summary>
  public string? XPath { get; set; }

  /// <summary>
  /// Custom XML data storage ID, identifying the XML data part to which the SDT is bound.
  /// </summary>
  public string? StoreItemId { get; set; }
}