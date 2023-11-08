namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the location of the child extents rectangle and is used for calculations of grouping, scaling, and rotation behavior of shapes placed within a group.
/// </summary>
public partial class ChildOffset: ModelElement<DXD.ChildOffset>
{
  public ChildOffset(): base(){ }
  
  public ChildOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChildOffset(DXD.ChildOffset openXmlElement): base(openXmlElement) { }
  
}
