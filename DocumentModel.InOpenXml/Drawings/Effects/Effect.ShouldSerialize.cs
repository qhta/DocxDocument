namespace DocumentModel.Drawings;

public partial class Effect
{
  public bool ShouldSerializeReference() => Reference is not null;
}
