namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeType: ModelElement<DXOD.GroupShapeType>
{
  public GroupShapeType(): base(){ }
  
  public GroupShapeType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeType(DXOD.GroupShapeType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GroupShapeNonVisualProperties.
  /// </summary>
  [DataMember]
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
      if (element != null)
        return GroupShapeNonVisualPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeNonVisualProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GroupShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.GroupShapeProperties>();
      if (element != null)
        return GroupShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.GroupShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapePropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
