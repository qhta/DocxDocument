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
      return _Element?.GetObject<DMDW.WrapPolygon,DXDW.WrapPolygon>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WrapPolygon,DXDW.WrapPolygon>(value);
    }
  }
  
}
