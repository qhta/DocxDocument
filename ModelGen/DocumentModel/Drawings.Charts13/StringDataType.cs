namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public partial class StringDataType: ModelElement<DXO13DC.StringDataType>
{
  public StringDataType(): base(){ }
  
  public StringDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringDataType(DXO13DC.StringDataType openXmlElement): base(openXmlElement) { }
  
  
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
  
}
