namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies decorations which can be added to the head of a line.
/// </summary>
public partial class HeadEnd: ModelElement<DXD.HeadEnd>
{
  public HeadEnd(): base(){ }
  
  public HeadEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeadEnd(DXD.HeadEnd openXmlElement): base(openXmlElement) { }
  
}
