namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Anchor for Floating DrawingML Object.
/// </summary>
public partial class Anchor: ModelElement<DXDW.Anchor>
{
  public Anchor(): base(){ }
  
  public Anchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Anchor(DXDW.Anchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromTop
  {
    get
    {
      return _Element?.DistanceFromTop?.Value;
    }
    set
    {
      _ExistingElement.DistanceFromTop = value;
    }
  }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromBottom
  {
    get
    {
      return _Element?.DistanceFromBottom?.Value;
    }
    set
    {
      _ExistingElement.DistanceFromBottom = value;
    }
  }
  
  
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromLeft
  {
    get
    {
      return _Element?.DistanceFromLeft?.Value;
    }
    set
    {
      _ExistingElement.DistanceFromLeft = value;
    }
  }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromRight
  {
    get
    {
      return _Element?.DistanceFromRight?.Value;
    }
    set
    {
      _ExistingElement.DistanceFromRight = value;
    }
  }
  
  
  /// <summary>
  ///   Page Positioning
  /// </summary>
  [DataMember]
  public Boolean? SimplePos
  {
    get
    {
      return _Element?.SimplePos?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SimplePos = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SimplePos = null;
    }
  }
  
  
  /// <summary>
  ///   Relative Z-Ordering Position
  /// </summary>
  [DataMember]
  public UInt32? RelativeHeight
  {
    get
    {
      return _Element?.RelativeHeight?.Value;
    }
    set
    {
      _ExistingElement.RelativeHeight = value;
    }
  }
  
  
  /// <summary>
  ///   Display Behind Document Text
  /// </summary>
  [DataMember]
  public Boolean? BehindDoc
  {
    get
    {
      return _Element?.BehindDoc?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.BehindDoc = null;
    }
  }
  
  
  /// <summary>
  ///   Lock Anchor
  /// </summary>
  [DataMember]
  public Boolean? Locked
  {
    get
    {
      return _Element?.Locked?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Locked = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Locked = null;
    }
  }
  
  
  /// <summary>
  ///   Layout In Table Cell
  /// </summary>
  [DataMember]
  public Boolean? LayoutInCell
  {
    get
    {
      return _Element?.LayoutInCell?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LayoutInCell = null;
    }
  }
  
  
  /// <summary>
  ///   Hidden
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get
    {
      return _Element?.Hidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Hidden = null;
    }
  }
  
  
  /// <summary>
  ///   Allow Objects to Overlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get
    {
      return _Element?.AllowOverlap?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.AllowOverlap = null;
    }
  }
  
  
  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? EditId
  {
    get
    {
      if (_Element?.EditId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.EditId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.EditId = value.ToString();
      else
        _ExistingElement.EditId = null;
    }
  }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? AnchorId
  {
    get
    {
      if (_Element?.AnchorId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.AnchorId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.AnchorId = value.ToString();
      else
        _ExistingElement.AnchorId = null;
    }
  }
  
  
  /// <summary>
  ///   Simple Positioning Coordinates.
  /// </summary>
  [DataMember]
  public DMDW.SimplePosition? SimplePosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.SimplePosition>();
      if (element != null)
        return SimplePositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.SimplePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SimplePositionConverter.CreateOpenXmlElement<DXDW.SimplePosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Horizontal Positioning.
  /// </summary>
  [DataMember]
  public DMDW.HorizontalPosition? HorizontalPosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.HorizontalPosition>();
      if (element != null)
        return HorizontalPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.HorizontalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HorizontalPositionConverter.CreateOpenXmlElement<DXDW.HorizontalPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Vertical Positioning.
  /// </summary>
  [DataMember]
  public DMDW.VerticalPosition? VerticalPosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.VerticalPosition>();
      if (element != null)
        return VerticalPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.VerticalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VerticalPositionConverter.CreateOpenXmlElement<DXDW.VerticalPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Inline Drawing Object Extents.
  /// </summary>
  [DataMember]
  public DMDW.Extent? Extent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.Extent>();
      if (element != null)
        return ExtentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.Extent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtentConverter.CreateOpenXmlElement<DXDW.Extent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EffectExtent.
  /// </summary>
  [DataMember]
  public DMDW.EffectExtent? EffectExtent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.EffectExtent>();
      if (element != null)
        return EffectExtentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectExtentConverter.CreateOpenXmlElement<DXDW.EffectExtent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WrapNone? WrapNone
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapNone>();
      if (element != null)
        return WrapNoneConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapNone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapNoneConverter.CreateOpenXmlElement<DXDW.WrapNone>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WrapSquare? WrapSquare
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapSquare>();
      if (element != null)
        return WrapSquareConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapSquare>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapSquareConverter.CreateOpenXmlElement<DXDW.WrapSquare>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WrapTight? WrapTight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapTight>();
      if (element != null)
        return WrapTightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapTight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapTightConverter.CreateOpenXmlElement<DXDW.WrapTight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WrapThrough? WrapThrough
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapThrough>();
      if (element != null)
        return WrapThroughConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapThrough>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapThroughConverter.CreateOpenXmlElement<DXDW.WrapThrough>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WrapTopBottom? WrapTopBottom
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapTopBottom>();
      if (element != null)
        return WrapTopBottomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapTopBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapTopBottomConverter.CreateOpenXmlElement<DXDW.WrapTopBottom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.DocProperties? DocProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.DocProperties>();
      if (element != null)
        return DocPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.DocProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPropertiesConverter.CreateOpenXmlElement<DXDW.DocProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
      if (element != null)
        return NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDW.NonVisualGraphicFrameDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
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
  
  [DataMember]
  public DMWD.RelativeWidth? RelativeWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10WD.RelativeWidth>();
      if (element != null)
        return RelativeWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10WD.RelativeWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeWidthConverter.CreateOpenXmlElement<DXO10WD.RelativeWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
