namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringCache Class.
/// </summary>
public partial class StringCache: ModelElement<DXDC.StringCache>
{
  public StringCache(): base(){ }
  
  public StringCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringCache(DXDC.StringCache openXmlElement): base(openXmlElement) { }
  
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
  public DMDC.StrDataExtensionList? StrDataExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.StrDataExtensionList,DXDC.StrDataExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StrDataExtensionList,DXDC.StrDataExtensionList>(value);
    }
  }
  
}
