namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Inline DrawingML Object.
/// </summary>
public partial class Inline: ModelElement<DXDW.Inline>
{
  public Inline(): base(){ }
  
  public Inline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Inline(DXDW.Inline openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Drawing Object Size.
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
  ///   Inline Wrapping Extent.
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
  
  
  /// <summary>
  ///   Drawing Object Non-Visual Properties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Common DrawingML Non-Visual Properties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Graphic.
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
