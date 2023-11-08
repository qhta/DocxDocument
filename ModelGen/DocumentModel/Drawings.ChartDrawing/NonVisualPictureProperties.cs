namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public partial class NonVisualPictureProperties: ModelElement<DXDCD.NonVisualPictureProperties>
{
  public NonVisualPictureProperties(): base(){ }
  
  public NonVisualPictureProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPictureProperties(DXDCD.NonVisualPictureProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
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
  ///   Non-Visual Picture Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualPictureDrawingProperties>();
      if (element != null)
        return NonVisualPictureDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualPictureDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualPictureDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualPictureDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
