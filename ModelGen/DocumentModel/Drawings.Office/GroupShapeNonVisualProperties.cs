namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public partial class GroupShapeNonVisualProperties: ModelElement<DXOD.GroupShapeNonVisualProperties>
{
  public GroupShapeNonVisualProperties(): base(){ }
  
  public GroupShapeNonVisualProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeNonVisualProperties(DXOD.GroupShapeNonVisualProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.NonVisualDrawingProperties>();
      if (element != null)
        return NonVisualDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.NonVisualGroupDrawingShapeProperties>();
      if (element != null)
        return NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.NonVisualGroupDrawingShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupDrawingShapePropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualGroupDrawingShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
