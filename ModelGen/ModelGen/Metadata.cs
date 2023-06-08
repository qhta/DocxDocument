namespace ModelGen;

/// <summary>
/// Metadata assigned to model element.
/// </summary>
public record Metadata
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
      if (value!=null)
        Summary = new XElement("summary", value);
      else
        Summary = null;
    }
  }

  /// <summary>
  /// Attribute tag in schema.
  /// </summary>
  public string? SchemaAttribute { get; set; }

  /// <summary>
  /// Element tag in schema.
  /// </summary>
  public string? SchemaElement { get; set; }

  /// <summary>
  /// Url for the shema tag namespace.
  /// </summary>
  public string? SchemaUrl { get; set; }

  /// <summary>
  /// Version of Office when the element is available.
  /// </summary>
  public string? Availability { get; set; }
}
