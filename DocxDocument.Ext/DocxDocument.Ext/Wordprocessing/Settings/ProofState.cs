namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies if the grammar and spell checking engines of the last application 
/// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
/// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
/// </summary>
[DataContract]
public partial class ProofState: IOpenXmlElementMappedObject
{
  public ProofState()
  {
    _Element = new DXW.ProofState();
  }

  public ProofState(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.ProofState)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ProofState(DXW.ProofState openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.ProofState _Element { get; private set; }

  [DataMember]
  public DMW.ProofingStateKind? Spelling
  {
    get => _Element.Spelling?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => _Element.Spelling = EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(value);
  }

  [DataMember]
  public DMW.ProofingStateKind? Grammar
  {
    get => _Element.Grammar?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => _Element.Grammar = EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(value);
  }

}
