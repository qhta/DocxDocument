namespace ModelGen;

/// <summary>
/// Metadata assigned to model element.
/// </summary>
public record ElementMetadata
{
  /// <summary>
  /// XElement representation of summary.
  /// </summary>
  public XElement? Summary { get; set; }

  /// <summary>
  /// Short text description of this element.
  /// </summary>
  public string? SummaryText
  {
    get => Summary?.Value;
    set
    {
      if (value != null)
        Summary = new XElement("summary", value);
      else
        Summary = null;
    }
  }

  /// <summary>
  /// Attribute/Element tag in schema.
  /// </summary>
  public string? SchemaTag { get; set; }

  /// <summary>
  /// SchemaTag is attrib
  /// </summary>
  public bool SchemaIsAttrib { get; set; }

  /// <summary>
  /// Prefix extracted from SchemaTag
  /// </summary>
  public string? SchemaPrefix
  {
    get
    {
      if (SchemaTag != null)
      {
        var k = SchemaTag.IndexOf(':');
        if (k>0)
          return SchemaTag.Substring(0, k);
      }
      return null;
    }
  }


  /// <summary>
  /// Url for the shema tag namespace.
  /// </summary>
  public string? SchemaUrl { get; set; }

  /// <summary>
  /// Version of Office when the element is available.
  /// </summary>
  public string? Availability { get; set; }
}
