namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class InsertedMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null && ShouldSerialize(DeletedMathControl);
}
