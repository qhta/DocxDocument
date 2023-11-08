namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Absolute Anchor Shape Size.
/// </summary>
public partial class AbsoluteAnchorSize: ModelElement<DXDCD.AbsoluteAnchorSize>
{
  public AbsoluteAnchorSize(): base(){ }
  
  public AbsoluteAnchorSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AbsoluteAnchorSize(DXDCD.AbsoluteAnchorSize openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   FromAnchor.
  /// </summary>
  [DataMember]
  public DMDCD.FromAnchor? FromAnchor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.FromAnchor>();
      if (element != null)
        return FromAnchorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.FromAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FromAnchorConverter.CreateOpenXmlElement<DXDCD.FromAnchor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Extent.
  /// </summary>
  [DataMember]
  public DMDCD.Extent? Extent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Extent>();
      if (element != null)
        return ExtentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Extent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtentConverter.CreateOpenXmlElement<DXDCD.Extent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.Shape? Shape
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Shape>();
      if (element != null)
        return ShapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeConverter.CreateOpenXmlElement<DXDCD.Shape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.GroupShape? GroupShape
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.GroupShape>();
      if (element != null)
        return GroupShapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.GroupShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeConverter.CreateOpenXmlElement<DXDCD.GroupShape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.GraphicFrame? GraphicFrame
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.GraphicFrame>();
      if (element != null)
        return GraphicFrameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.GraphicFrame>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicFrameConverter.CreateOpenXmlElement<DXDCD.GraphicFrame>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.ConnectionShape? ConnectionShape
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.ConnectionShape>();
      if (element != null)
        return ConnectionShapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.ConnectionShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionShapeConverter.CreateOpenXmlElement<DXDCD.ConnectionShape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.Picture? Picture
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Picture>();
      if (element != null)
        return PictureConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Picture>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureConverter.CreateOpenXmlElement<DXDCD.Picture>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
