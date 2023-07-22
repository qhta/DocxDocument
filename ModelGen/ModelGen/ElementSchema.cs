namespace ModelGen;

/// <summary>
/// A schema of the model element as read from OpenXml element metadata.
/// Contains one "main" schema particle.
/// </summary>
public class ElementSchema
{
  /// <summary>
  /// Attribute/Element tag in schema.
  /// </summary>
  public string? SchemaTag { get; set; }

  /// <summary>
  /// SchemaTag is attrib
  /// </summary>
  public bool SchemaIsAttrib { get; set; }

  /// <summary>
  /// Url for the schema tag namespace.
  /// </summary>
  public string? SchemaUrl { get; set; }

  /// <summary>
  /// Main particle in compound element
  /// </summary>
  public SchemaParticle? Main { get; set; }
}
