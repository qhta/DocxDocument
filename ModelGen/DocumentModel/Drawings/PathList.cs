namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the entire path that is to make up a single geometric shape. The pathLst can consist of many individual paths within it.
/// </summary>
public partial class PathList: ModelElement<DXD.PathList>
{
  public PathList(): base(){ }
  
  public PathList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PathList(DXD.PathList openXmlElement): base(openXmlElement) { }
  
}
