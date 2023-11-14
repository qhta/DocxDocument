namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies if the grammar and spell checking engines of the last application 
/// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
/// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
/// </summary>
[DataContract]
public partial class ProofState : ModelElement<DXW.ProofState>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ProofState(): base(){ }

  public ProofState(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ProofState(DXW.ProofState openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  [DataMember]
  public DMW.ProofingStateKind? Spelling
  {
    get => _Element?.Spelling?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => _ExistingElement.Spelling = EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(value);
  }

  [DataMember]
  public DMW.ProofingStateKind? Grammar
  {
    get => _Element?.Grammar?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => _ExistingElement.Grammar = EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(value);
  }

}
