namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Properties.
/// </summary>
public partial class NonVisualShapeProperties: ModelElement<DXDCD.NonVisualShapeProperties>
{
  public NonVisualShapeProperties(): base(){ }
  
  public NonVisualShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualShapeProperties(DXDCD.NonVisualShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualShapeDrawingProperties>();
      if (element != null)
        return NonVisualShapeDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualShapeDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
