namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom XML attribute in a WordprocessingML document.
/// This class extends <see cref="CollectionItem"/> and provides properties for the attribute UriString, name, and value, enabling advanced storage and management of custom metadata or schema-specific attributes within custom XML parts.
/// </summary>
public class CustomXmlAttribute: ModelElement<DXW.CustomXmlAttribute>
{
  
  /// <summary>
  /// UriString of the custom XML attribute, specifying the namespace or schema context.
  /// </summary>
  public string? UriString { get; set; }
  
  /// <summary>
  /// Name of the custom XML attribute.
  /// </summary>
  public string? Name { get; set; }
  
  /// <summary>
  /// Value of the custom XML attribute.
  /// </summary>
  public string? Val { get; set; }
}