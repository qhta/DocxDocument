namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the size of the bounding box enclosing the referenced object.
/// </summary>
public partial class Extents: ModelElement<DXD.Extents>
{
  public Extents(): base(){ }
  
  public Extents(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extents(DXD.Extents openXmlElement): base(openXmlElement) { }
  
}
