namespace ModelGen;

/// <summary>
/// Metadata assigned to model element.
/// </summary>
public record ElementMetadata
{
  /// <summary>
  /// Short text description of this element.
  /// </summary>
  public string? Summary { get; set; }

  /// <summary>
  /// Element tag in schema.
  /// </summary>
  public string? SchemaTag { get; set; }

  /// <summary>
  /// Url for the shema tag namespace.
  /// </summary>
  public string? SchemaUrl { get; set; }

  /// <summary>
  /// Version of Office when the element is available.
  /// </summary>
  public string? Availability { get; set; }
}
