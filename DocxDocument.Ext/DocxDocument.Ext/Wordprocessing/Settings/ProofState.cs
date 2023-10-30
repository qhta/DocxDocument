namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies if the grammar and spell checking engines of the last application 
/// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
/// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
/// </summary>
public partial class ProofState
{
  public ProofState(DXW.ProofState openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.ProofState _Element { get; private set; }

  public DXW.ProofingStateValues? Spelling
  {
    get => _Element.Spelling?.Value;
    set
    {
      if (value != null)
        _Element.Spelling = new DX.EnumValue<DXW.ProofingStateValues> { Value = (DXW.ProofingStateValues)value };
      else
        _Element.Spelling = null;
    }
  }

  public DXW.ProofingStateValues? Grammar
  {
    get => _Element.Grammar?.Value;
    set
    {
      if (value != null)
        _Element.Grammar = new DX.EnumValue<DXW.ProofingStateValues> { Value = (DXW.ProofingStateValues)value };
      else
        _Element.Grammar = null;
    }
  }

}
