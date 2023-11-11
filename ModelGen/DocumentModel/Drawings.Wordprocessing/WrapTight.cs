namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping.
/// </summary>
public partial class WrapTight: ModelElement<DXDW.WrapTight>
{
  public WrapTight(): base(){ }
  
  public WrapTight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapTight(DXDW.WrapTight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance From Test on Left Edge
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
  ///   Tight Wrapping Extents Polygon.
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
