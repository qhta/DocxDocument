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
        _ExistingElement.SimplePos = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.BehindDoc = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.Locked = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.LayoutInCell = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.Hidden = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.AllowOverlap = new DX.BooleanValue { Value = (Boolean)value };
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
        return HexIntConverter.GetValue(_Element?.EditId.Value);
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
        return HexIntConverter.GetValue(_Element?.AnchorId.Value);
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
      return _Element?.GetObject<DMDW.SimplePosition,DXDW.SimplePosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.SimplePosition,DXDW.SimplePosition>(value);
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
      return _Element?.GetObject<DMDW.HorizontalPosition,DXDW.HorizontalPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.HorizontalPosition,DXDW.HorizontalPosition>(value);
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
      return _Element?.GetObject<DMDW.VerticalPosition,DXDW.VerticalPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.VerticalPosition,DXDW.VerticalPosition>(value);
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
      return _Element?.GetObject<DMDW.Extent,DXDW.Extent>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.Extent,DXDW.Extent>(value);
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
      return _Element?.GetObject<DMDW.EffectExtent,DXDW.EffectExtent>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.EffectExtent,DXDW.EffectExtent>(value);
    }
  }
  
  [DataMember]
  public DMDW.WrapNone? WrapNone
  {
    get
    {
      return _Element?.GetObject<DMDW.WrapNone,DXDW.WrapNone>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapNone,DXDW.WrapNone>(value);
    }
  }
  
  [DataMember]
  public DMDW.WrapSquare? WrapSquare
  {
    get
    {
      return _Element?.GetObject<DMDW.WrapSquare,DXDW.WrapSquare>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapSquare,DXDW.WrapSquare>(value);
    }
  }
  
  [DataMember]
  public DMDW.WrapTight? WrapTight
  {
    get
    {
      return _Element?.GetObject<DMDW.WrapTight,DXDW.WrapTight>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapTight,DXDW.WrapTight>(value);
    }
  }
  
  [DataMember]
  public DMDW.WrapThrough? WrapThrough
  {
    get
    {
      return _Element?.GetObject<DMDW.WrapThrough,DXDW.WrapThrough>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapThrough,DXDW.WrapThrough>(value);
    }
  }
  
  [DataMember]
  public DMDW.WrapTopBottom? WrapTopBottom
  {
    get
    {
      return _Element?.GetObject<DMDW.WrapTopBottom,DXDW.WrapTopBottom>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapTopBottom,DXDW.WrapTopBottom>(value);
    }
  }
  
  [DataMember]
  public DMDW.DocProperties? DocProperties
  {
    get
    {
      return _Element?.GetObject<DMDW.DocProperties,DXDW.DocProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.DocProperties,DXDW.DocProperties>(value);
    }
  }
  
  [DataMember]
  public DMDW.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDW.NonVisualGraphicFrameDrawingProperties,DXDW.NonVisualGraphicFrameDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.NonVisualGraphicFrameDrawingProperties,DXDW.NonVisualGraphicFrameDrawingProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.Graphic? Graphic
  {
    get
    {
      return _Element?.GetObject<DMD.Graphic,DXD.Graphic>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Graphic,DXD.Graphic>(value);
    }
  }
  
  [DataMember]
  public DMWD.RelativeWidth? RelativeWidth
  {
    get
    {
      return _Element?.GetObject<DMWD.RelativeWidth,DXO10WD.RelativeWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMWD.RelativeWidth,DXO10WD.RelativeWidth>(value);
    }
  }
  
}
