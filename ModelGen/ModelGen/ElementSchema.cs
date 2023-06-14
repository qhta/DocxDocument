namespace ModelGen;
public class ElementSchema
{
  public ElementSchema(SchemaParticle schemaParticle)
  {
    Main = schemaParticle;
  }

  public SchemaParticle Main { get; set; }
}
