namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Relative Anchor Shape Size.
/// </summary>
public partial class RelativeAnchorSize: ModelElement<DXDCD.RelativeAnchorSize>
{
  public RelativeAnchorSize(): base(){ }
  
  public RelativeAnchorSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeAnchorSize(DXDCD.RelativeAnchorSize openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Starting Anchor Point.
  /// </summary>
  [DataMember]
  public DMDCD.FromAnchor? FromAnchor
  {
    get
    {
      return _Element?.GetObject<DMDCD.FromAnchor,DXDCD.FromAnchor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.FromAnchor,DXDCD.FromAnchor>(value);
    }
  }
  
  
  /// <summary>
  ///   Ending Anchor Point.
  /// </summary>
  [DataMember]
  public DMDCD.ToAnchor? ToAnchor
  {
    get
    {
      return _Element?.GetObject<DMDCD.ToAnchor,DXDCD.ToAnchor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.ToAnchor,DXDCD.ToAnchor>(value);
    }
  }
  
  [DataMember]
  public DMDCD.Shape? Shape
  {
    get
    {
      return _Element?.GetObject<DMDCD.Shape,DXDCD.Shape>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.Shape,DXDCD.Shape>(value);
    }
  }
  
  [DataMember]
  public DMDCD.GroupShape? GroupShape
  {
    get
    {
      return _Element?.GetObject<DMDCD.GroupShape,DXDCD.GroupShape>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.GroupShape,DXDCD.GroupShape>(value);
    }
  }
  
  [DataMember]
  public DMDCD.GraphicFrame? GraphicFrame
  {
    get
    {
      return _Element?.GetObject<DMDCD.GraphicFrame,DXDCD.GraphicFrame>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.GraphicFrame,DXDCD.GraphicFrame>(value);
    }
  }
  
  [DataMember]
  public DMDCD.ConnectionShape? ConnectionShape
  {
    get
    {
      return _Element?.GetObject<DMDCD.ConnectionShape,DXDCD.ConnectionShape>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.ConnectionShape,DXDCD.ConnectionShape>(value);
    }
  }
  
  [DataMember]
  public DMDCD.Picture? Picture
  {
    get
    {
      return _Element?.GetObject<DMDCD.Picture,DXDCD.Picture>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.Picture,DXDCD.Picture>(value);
    }
  }
  
}
