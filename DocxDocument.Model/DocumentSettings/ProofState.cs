namespace DocxDocument.Model;

public class ProofState: DocxBasedElement<WD.ProofState>, IProofState
{
  public ProofState(): base(new WD.ProofState()){}

  public ProofState(WD.ProofState element) : base(element)
  {
  }

  [XmlAttribute]
  public DM.ProofingState? Spelling
  {
    get => (DM.ProofingState?)DocxElement.Spelling?.Value;
    set => DocxElement.Spelling = (WD.ProofingStateValues?)value;
  }

  [XmlAttribute]
  public DM.ProofingState? Grammar
  {
    get => (DM.ProofingState?)DocxElement.Grammar?.Value;
    set => DocxElement.Grammar = (WD.ProofingStateValues?)value;
  }
}