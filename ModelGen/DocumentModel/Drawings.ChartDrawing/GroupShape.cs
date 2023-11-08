namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Group Shape.
/// </summary>
public partial class GroupShape: ModelElement<DXDCD.GroupShape>
{
  public GroupShape(): base(){ }
  
  public GroupShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShape(DXDCD.GroupShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Non-Visual Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualGroupShapeProperties>();
      if (element != null)
        return NonVisualGroupShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualGroupShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGroupShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.GroupShapeProperties>();
      if (element != null)
        return GroupShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.GroupShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapePropertiesConverter.CreateOpenXmlElement<DXDCD.GroupShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
