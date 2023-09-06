namespace ModelGenApp.ViewModels;
public class SchemaParticleViewModel: ViewModel<SchemaParticle>
{
  public SchemaParticleViewModel(SchemaParticle schemaParticle): base(schemaParticle)
  { }

  public ParticleType ParticleType => Model.ParticleType;

  public string? Name => Model.Name;

  public bool IsRequired => Model.IsRequired;
  public bool IsMultiple => Model.IsMultiple;
  public int? MinOccurs => Model.MinOccurs;
  public int? MaxOccurs => Model.MaxOccurs;

}
