namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a Bevel Line Join.
/// </summary>
public partial class LineJoinBevel: ModelElement<DXD.LineJoinBevel>
{
  public LineJoinBevel(): base(){ }
  
  public LineJoinBevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineJoinBevel(DXD.LineJoinBevel openXmlElement): base(openXmlElement) { }
  
}
