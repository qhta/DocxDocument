namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Effect
{
  public bool ShouldSerializeReference() => !String.IsNullOrEmpty(Reference);
}
