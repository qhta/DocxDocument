namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public partial class Point2DType: ModelElement<DXDW.Point2DType>
{
  public Point2DType(): base(){ }
  
  public Point2DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Point2DType(DXDW.Point2DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X-Axis Coordinate
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
  ///   Y-Axis Coordinate
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
  
}
