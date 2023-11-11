namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public partial class NumberingCache: ModelElement<DXDC.NumberingCache>
{
  public NumberingCache(): base(){ }
  
  public NumberingCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingCache(DXDC.NumberingCache openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get
    {
      return _Element?.GetObject<DMDC.FormatCode,DXDC.FormatCode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FormatCode,DXDC.FormatCode>(value);
    }
  }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get
    {
      return _Element?.GetObject<DMDC.PointCount,DXDC.PointCount>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PointCount,DXDC.PointCount>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
