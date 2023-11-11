namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Minus.
/// </summary>
public partial class Minus: ModelElement<DXDC.Minus>
{
  public Minus(): base(){ }
  
  public Minus(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Minus(DXDC.Minus openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberReference,DXDC.NumberReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberReference,DXDC.NumberReference>(value);
    }
  }
  
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberLiteral,DXDC.NumberLiteral>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberLiteral,DXDC.NumberLiteral>(value);
    }
  }
  
}
