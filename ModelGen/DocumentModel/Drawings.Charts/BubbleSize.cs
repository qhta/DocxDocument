namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleSize Class.
/// </summary>
public partial class BubbleSize: ModelElement<DXDC.BubbleSize>
{
  public BubbleSize(): base(){ }
  
  public BubbleSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleSize(DXDC.BubbleSize openXmlElement): base(openXmlElement) { }
  
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
