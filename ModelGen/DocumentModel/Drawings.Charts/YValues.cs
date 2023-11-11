namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the YValues Class.
/// </summary>
public partial class YValues: ModelElement<DXDC.YValues>
{
  public YValues(): base(){ }
  
  public YValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public YValues(DXDC.YValues openXmlElement): base(openXmlElement) { }
  
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
