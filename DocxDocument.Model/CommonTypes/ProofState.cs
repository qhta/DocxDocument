namespace DocxDocument.Model;

public struct ProofState
{
  public ProofingState? Spelling { get; set; }
  public ProofingState? Grammar { get; set; }
}