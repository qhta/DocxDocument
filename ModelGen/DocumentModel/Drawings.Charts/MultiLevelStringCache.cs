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
      var element = _Element?.GetFirstChild<DXDC.PointCount>();
      if (element != null)
        return PointCountConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PointCountConverter.CreateOpenXmlElement<DXDC.PointCount>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
