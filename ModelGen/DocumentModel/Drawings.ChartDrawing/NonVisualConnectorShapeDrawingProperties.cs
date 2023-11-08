namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connector Non Visual Properties.
/// </summary>
public partial class NonVisualConnectorShapeDrawingProperties: ModelElement<DXDCD.NonVisualConnectorShapeDrawingProperties>
{
  public NonVisualConnectorShapeDrawingProperties(): base(){ }
  
  public NonVisualConnectorShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualConnectorShapeDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualConnectionShapeProperties>();
      if (element != null)
        return NonVisualConnectionShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualConnectionShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualConnectionShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
