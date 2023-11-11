namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the drawing of a straight line from the current pen position to the new point specified. This line becomes part of the shape geometry, representing a side of the shape. The coordinate system used when specifying this line is the path coordinate system.
/// </summary>
public partial class LineTo: ModelElement<DXD.LineTo>
{
  public LineTo(): base(){ }
  
  public LineTo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineTo(DXD.LineTo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Line end point.
  /// </summary>
  [DataMember]
  public DMD.Point? Point
  {
    get
    {
      return _Element?.GetObject<DMD.Point,DXD.Point>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Point,DXD.Point>(value);
    }
  }
  
}
