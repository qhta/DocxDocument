namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the XValues Class.
/// </summary>
public partial class XValues: ModelElement<DXDC.XValues>
{
  public XValues(): base(){ }
  
  public XValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public XValues(DXDC.XValues openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.MultiLevelStringReference? MultiLevelStringReference
  {
    get
    {
      return _Element?.GetObject<DMDC.MultiLevelStringReference,DXDC.MultiLevelStringReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MultiLevelStringReference,DXDC.MultiLevelStringReference>(value);
    }
  }
  
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
  
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      return _Element?.GetObject<DMDC.StringReference,DXDC.StringReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringReference,DXDC.StringReference>(value);
    }
  }
  
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get
    {
      return _Element?.GetObject<DMDC.StringLiteral,DXDC.StringLiteral>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringLiteral,DXDC.StringLiteral>(value);
    }
  }
  
}
