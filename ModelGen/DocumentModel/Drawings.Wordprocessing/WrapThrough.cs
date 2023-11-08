namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Through Wrapping.
/// </summary>
public partial class WrapThrough: ModelElement<DXDW.WrapThrough>
{
  public WrapThrough(): base(){ }
  
  public WrapThrough(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapThrough(DXDW.WrapThrough openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Wrapping Polygon.
  /// </summary>
  [DataMember]
  public DMDW.WrapPolygon? WrapPolygon
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.WrapPolygon>();
      if (element != null)
        return WrapPolygonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.WrapPolygon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapPolygonConverter.CreateOpenXmlElement<DXDW.WrapPolygon>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
