namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Square Wrapping.
/// </summary>
public partial class WrapSquare: ModelElement<DXDW.WrapSquare>
{
  public WrapSquare(): base(){ }
  
  public WrapSquare(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapSquare(DXDW.WrapSquare openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance From Text (Top)
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
  ///   Object Extents Including Effects.
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
  
}
