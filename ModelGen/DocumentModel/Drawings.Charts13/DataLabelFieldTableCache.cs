namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public partial class DataLabelFieldTableCache: ModelElement<DXO13DC.DataLabelFieldTableCache>
{
  public DataLabelFieldTableCache(): base(){ }
  
  public DataLabelFieldTableCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelFieldTableCache(DXO13DC.DataLabelFieldTableCache openXmlElement): base(openXmlElement) { }
  
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
