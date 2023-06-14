namespace ModelGen;

/// <summary>
/// A schema of the model element as read from OpenXml element metadata.
/// Contains one "main" schema particle.
/// </summary>
public class ElementSchema
{
  public ElementSchema(SchemaParticle schemaParticle)
  {
    Main = schemaParticle;
  }

  public SchemaParticle Main { get; set; }
}
