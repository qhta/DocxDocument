namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Defines the base interface for custom XML elements (customXml) in a WordprocessingML document.
  /// This interface provides properties for the custom XML markup namespace, element name, and associated custom XML properties, enabling advanced schema-based processing, annotation, and integration of custom XML data within document content.
  /// </summary>
  public class CustomXmlElement: CollectionItem
  {
    
    /// <summary>
    /// Custom XML markup namespace UriString associated with the element.
    /// </summary>
    public string? UriString { get; set; }
    
    /// <summary>
    /// Name of the custom XML element.
    /// </summary>
    public string? Element { get; set; }
    
    /// <summary>
    /// Custom XML properties representing the element tag in the schema (w:customXmlPr).
    /// </summary>
    public CustomXmlProperties? CustomXmlProperties { get; set; }

    protected override object? GetUpdatableOpenXmlElement()
    {
      throw new NotImplementedException();
    }
  }