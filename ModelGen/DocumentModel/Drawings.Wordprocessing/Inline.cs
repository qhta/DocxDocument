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
  ///   Drawing Object Size.
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
  ///   Inline Wrapping Extent.
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
  
  
  /// <summary>
  ///   Drawing Object Non-Visual Properties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Common DrawingML Non-Visual Properties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Graphic.
  /// </summary>
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
  
}
