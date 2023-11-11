namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelsRangeChache Class.
/// </summary>
public partial class DataLabelsRangeChache: ModelElement<DXO13DC.DataLabelsRangeChache>
{
  public DataLabelsRangeChache(): base(){ }
  
  public DataLabelsRangeChache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelsRangeChache(DXO13DC.DataLabelsRangeChache openXmlElement): base(openXmlElement) { }
  
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
