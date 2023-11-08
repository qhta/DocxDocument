namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a point in 3D space.  This point is the point in space that anchors the backdrop plane.
/// </summary>
public partial class Anchor: ModelElement<DXD.Anchor>
{
  public Anchor(): base(){ }
  
  public Anchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Anchor(DXD.Anchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? X
  {
    get
    {
      return _Element?.X?.Value;
    }
    set
    {
      _ExistingElement.X = value;
    }
  }
  
  
  /// <summary>
  ///   Y-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? Y
  {
    get
    {
      return _Element?.Y?.Value;
    }
    set
    {
      _ExistingElement.Y = value;
    }
  }
  
  
  /// <summary>
  ///   Z-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get
    {
      return _Element?.Z?.Value;
    }
    set
    {
      _ExistingElement.Z = value;
    }
  }
  
}
