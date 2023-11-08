namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connection Shape.
/// </summary>
public partial class ConnectionShape: ModelElement<DXDCD.ConnectionShape>
{
  public ConnectionShape(): base(){ }
  
  public ConnectionShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionShape(DXDCD.ConnectionShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualConnectorShapeDrawingProperties>();
      if (element != null)
        return NonVisualConnectorShapeDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualConnectorShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualConnectorShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualConnectorShapeDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Connection Shape Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Style>();
      if (element != null)
        return StyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DXDCD.Style>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
