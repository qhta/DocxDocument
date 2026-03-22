namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class ProofState
{
  public bool ShouldSerializeSpelling() => Spelling is not null;
  public bool ShouldSerializeGrammar() => Grammar is not null;
}
