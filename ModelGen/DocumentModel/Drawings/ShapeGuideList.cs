namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all the guides that are used for this shape. A guide is specified by the gd element and defines a calculated value that can be used for the construction of the corresponding shape.
/// </summary>
public partial class ShapeGuideList: ModelElement<DXD.ShapeGuideList>
{
  public ShapeGuideList(): base(){ }
  
  public ShapeGuideList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeGuideList(DXD.ShapeGuideList openXmlElement): base(openXmlElement) { }
  
}
