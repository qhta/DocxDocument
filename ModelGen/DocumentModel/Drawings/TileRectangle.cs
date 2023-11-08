namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a rectangular region of the shape to which the gradient is applied. This region is then tiled across the remaining area of the shape to complete the fill. The tile rectangle is defined by percentage offsets from the sides of the shape's bounding box.
/// </summary>
public partial class TileRectangle: ModelElement<DXD.TileRectangle>
{
  public TileRectangle(): base(){ }
  
  public TileRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TileRectangle(DXD.TileRectangle openXmlElement): base(openXmlElement) { }
  
}
