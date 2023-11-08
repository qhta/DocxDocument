namespace DocumentModel.Drawings;


/// <summary>
///   Specifies a position coordinate within the shape bounding box. It should be noted that this coordinate is placed within the shape bounding box using the transform coordinate system which is also called the shape coordinate system, as it encompasses the entire shape. The width and height for this coordinate system are specified within the ext transform element.
/// </summary>
public partial class Position: ModelElement<DXD.Position>
{
  public Position(): base(){ }
  
  public Position(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Position(DXD.Position openXmlElement): base(openXmlElement) { }
  
}
