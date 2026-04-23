namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DeletedMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
}
