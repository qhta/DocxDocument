namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies decorations which can be added to the tail of a line.
/// </summary>
public partial class TailEnd: ModelElement<DXD.TailEnd>
{
  public TailEnd(): base(){ }
  
  public TailEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TailEnd(DXD.TailEnd openXmlElement): base(openXmlElement) { }
  
}
