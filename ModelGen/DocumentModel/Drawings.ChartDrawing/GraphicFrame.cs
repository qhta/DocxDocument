namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Graphic Frame.
/// </summary>
public partial class GraphicFrame: ModelElement<DXDCD.GraphicFrame>
{
  public GraphicFrame(): base(){ }
  
  public GraphicFrame(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicFrame(DXDCD.GraphicFrame openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Publish To Server
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
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualGraphicFrameProperties>();
      if (element != null)
        return NonVisualGraphicFramePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualGraphicFrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGraphicFramePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGraphicFrameProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  [DataMember]
  public DMDCD.Transform? Transform
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Transform>();
      if (element != null)
        return TransformConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Transform>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TransformConverter.CreateOpenXmlElement<DXDCD.Transform>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Graphical Object.
  /// </summary>
  [DataMember]
  public DMD.Graphic? Graphic
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Graphic>();
      if (element != null)
        return GraphicConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicConverter.CreateOpenXmlElement<DXD.Graphic>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
