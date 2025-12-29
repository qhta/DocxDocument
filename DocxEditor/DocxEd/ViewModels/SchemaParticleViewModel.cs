namespace DocxEd.ViewModels;
public class SchemaParticleViewModel: ViewModel<SchemaParticle>
{
  public SchemaParticleViewModel(SchemaParticle schemaParticle): base(schemaParticle)
  { }

  public ParticleType ParticleType => Model.ParticleType;

  public string? Name => Model.Name;

}
