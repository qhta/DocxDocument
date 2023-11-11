namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public partial class MultiLevelStringCache: ModelElement<DXDC.MultiLevelStringCache>
{
  public MultiLevelStringCache(): base(){ }
  
  public MultiLevelStringCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MultiLevelStringCache(DXDC.MultiLevelStringCache openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PointCount.
  /// </summary>
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
