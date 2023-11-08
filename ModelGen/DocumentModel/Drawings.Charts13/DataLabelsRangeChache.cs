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
