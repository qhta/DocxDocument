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
  public DMDC.StrDataExtensionList? StrDataExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StrDataExtensionList>();
      if (element != null)
        return StrDataExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StrDataExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrDataExtensionListConverter.CreateOpenXmlElement<DXDC.StrDataExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
