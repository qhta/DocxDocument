namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Fill Color List.
/// </summary>
public partial class FillColorList: ModelElement<DXDDD.FillColorList>
{
  public FillColorList(): base(){ }
  
  public FillColorList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillColorList(DXDDD.FillColorList openXmlElement): base(openXmlElement) { }
  
}
