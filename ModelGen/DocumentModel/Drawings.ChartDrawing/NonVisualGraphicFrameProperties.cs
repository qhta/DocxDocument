namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Graphic Frame Properties.
/// </summary>
public partial class NonVisualGraphicFrameProperties: ModelElement<DXDCD.NonVisualGraphicFrameProperties>
{
  public NonVisualGraphicFrameProperties(): base(){ }
  
  public NonVisualGraphicFrameProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGraphicFrameProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Non-Visual Drawing Properties.
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
  ///   Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualGraphicFrameDrawingProperties>();
      if (element != null)
        return NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualGraphicFrameDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGraphicFrameDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
