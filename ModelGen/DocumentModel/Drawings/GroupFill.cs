namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a group fill. When specified, this setting indicates that the parent element is part of a group and should inherit the fill properties of the group.
/// </summary>
public partial class GroupFill: ModelElement<DXD.GroupFill>
{
  public GroupFill(): base(){ }
  
  public GroupFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupFill(DXD.GroupFill openXmlElement): base(openXmlElement) { }
  
}
