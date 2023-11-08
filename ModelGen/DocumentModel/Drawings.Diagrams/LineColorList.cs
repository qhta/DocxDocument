namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Line Color List.
/// </summary>
public partial class LineColorList: ModelElement<DXDDD.LineColorList>
{
  public LineColorList(): base(){ }
  
  public LineColorList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineColorList(DXDDD.LineColorList openXmlElement): base(openXmlElement) { }
  
}
