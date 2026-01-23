namespace DocumentModel.Wordprocessing;

public partial class ProofError
{
  public bool ShouldSerializeType() => Type is not null;
}
