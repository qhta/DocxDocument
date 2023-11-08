namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the size dimensions of the child extents rectangle and is used for calculations of grouping, scaling, and rotation behavior of shapes placed within a group.
/// </summary>
public partial class ChildExtents: ModelElement<DXD.ChildExtents>
{
  public ChildExtents(): base(){ }
  
  public ChildExtents(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChildExtents(DXD.ChildExtents openXmlElement): base(openXmlElement) { }
  
}
