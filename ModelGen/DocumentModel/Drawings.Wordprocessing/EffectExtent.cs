namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Object Extents Including Effects.
/// </summary>
public partial class EffectExtent: ModelElement<DXDW.EffectExtent>
{
  public EffectExtent(): base(){ }
  
  public EffectExtent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectExtent(DXDW.EffectExtent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  [DataMember]
  public Int64? LeftEdge
  {
    get
    {
      return _Element?.LeftEdge?.Value;
    }
    set
    {
      _ExistingElement.LeftEdge = value;
    }
  }
  
  
  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  [DataMember]
  public Int64? TopEdge
  {
    get
    {
      return _Element?.TopEdge?.Value;
    }
    set
    {
      _ExistingElement.TopEdge = value;
    }
  }
  
  
  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  [DataMember]
  public Int64? RightEdge
  {
    get
    {
      return _Element?.RightEdge?.Value;
    }
    set
    {
      _ExistingElement.RightEdge = value;
    }
  }
  
  
  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  [DataMember]
  public Int64? BottomEdge
  {
    get
    {
      return _Element?.BottomEdge?.Value;
    }
    set
    {
      _ExistingElement.BottomEdge = value;
    }
  }
  
}
