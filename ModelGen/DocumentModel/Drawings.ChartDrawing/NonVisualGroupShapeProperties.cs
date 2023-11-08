namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Group Shape Properties.
/// </summary>
public partial class NonVisualGroupShapeProperties: ModelElement<DXDCD.NonVisualGroupShapeProperties>
{
  public NonVisualGroupShapeProperties(): base(){ }
  
  public NonVisualGroupShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupShapeProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
      if (element != null)
        return NonVisualDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Group Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualGroupShapeDrawingProperties>();
      if (element != null)
        return NonVisualGroupShapeDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualGroupShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGroupShapeDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
