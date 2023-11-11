namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Values Class.
/// </summary>
public partial class Values: ModelElement<DXDC.Values>
{
  public Values(): base(){ }
  
  public Values(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Values(DXDC.Values openXmlElement): base(openXmlElement) { }
  
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
