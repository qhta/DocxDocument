namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Run
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeText() => Text is not null;
}
