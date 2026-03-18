namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class LevelReference
{
  public bool ShouldSerializeSequenceOfReferences() => !String.IsNullOrEmpty(SequenceOfReferences);
}
