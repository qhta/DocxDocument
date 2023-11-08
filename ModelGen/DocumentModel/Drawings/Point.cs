namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an x-y coordinate within the path coordinate space. This coordinate space is determined by the width and height attributes defined within the path element. A point is utilized by one of it's parent elements to specify the next point of interest in custom geometry shape. Depending on the parent element used the point can either have a line drawn to it or the cursor can simply be moved to this new location.
/// </summary>
public partial class Point: ModelElement<DXD.Point>
{
  public Point(): base(){ }
  
  public Point(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Point(DXD.Point openXmlElement): base(openXmlElement) { }
  
}
