namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree: ModelElement<DXOD.ShapeTree>
{
  public ShapeTree(): base(){ }
  
  public ShapeTree(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeTree(DXOD.ShapeTree openXmlElement): base(openXmlElement) { }
  
}
