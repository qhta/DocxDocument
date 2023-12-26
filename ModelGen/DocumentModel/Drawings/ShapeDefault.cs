namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the formatting that is associated with the default shape.  The default formatting can be applied to a shape when it is initially inserted into a document.
/// </summary>
public partial class ShapeDefault: ModelElement<DXD.ShapeDefault>
{
  public ShapeDefault(): base(){ }
  
  public ShapeDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeDefault(DXD.ShapeDefault openXmlElement): base(openXmlElement) { }
  
}
