namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom XML attribute in a WordprocessingML document.
/// This interface extends <see cref="CollectionItem"/> and provides properties for the attribute URI, name, and value, enabling advanced storage and management of custom metadata or schema-specific attributes within custom XML parts.
/// </summary>
public interface CustomXmlAttribute : CollectionItem
{
  
  /// <summary>
  /// URI of the custom XML attribute, specifying the namespace or schema context.
  /// </summary>
  public string? Uri { get; set; }
  
  /// <summary>
  /// Name of the custom XML attribute.
  /// </summary>
  public string? Name { get; set; }
  
  /// <summary>
  /// Value of the custom XML attribute.
  /// </summary>
  public string? Val { get; set; }
}