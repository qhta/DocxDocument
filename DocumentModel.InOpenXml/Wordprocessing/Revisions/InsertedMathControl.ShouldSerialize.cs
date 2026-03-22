namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class InsertedMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null;
}
