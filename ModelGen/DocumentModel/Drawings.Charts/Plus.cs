namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plus.
/// </summary>
public partial class Plus: ModelElement<DXDC.Plus>
{
  public Plus(): base(){ }
  
  public Plus(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Plus(DXDC.Plus openXmlElement): base(openXmlElement) { }
  
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
