namespace DocumentModel.Wordprocessing;

public partial class ProofState
{
  public bool ShouldSerializeSpelling() => Spelling is not null;
  public bool ShouldSerializeGrammar() => Grammar is not null;
}
