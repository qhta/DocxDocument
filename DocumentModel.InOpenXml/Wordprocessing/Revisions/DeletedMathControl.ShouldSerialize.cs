namespace DocumentModel.Wordprocessing;

public partial class DeletedMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
