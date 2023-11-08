namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Top and Bottom Wrapping.
/// </summary>
public partial class WrapTopBottom: ModelElement<DXDW.WrapTopBottom>
{
  public WrapTopBottom(): base(){ }
  
  public WrapTopBottom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapTopBottom(DXDW.WrapTopBottom openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Wrapping Boundaries.
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
