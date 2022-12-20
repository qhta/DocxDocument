namespace DocxDocument.Model;

public interface IProofState
{
  [XmlAttribute]
  public DM.ProofingState? Spelling{ get; set; }
  [XmlAttribute]
  public DM.ProofingState? Grammar { get; set; }
}