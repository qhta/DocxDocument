namespace DocumentModel.Wordprocessing;


/// <summary>
///   Align Paragraph and Table Borders with Page Border.
/// </summary>
public partial class AlignBorderAndEdges: ModelElement<DXW.AlignBorderAndEdges>
{
  public AlignBorderAndEdges(): base(){ }
  
  public AlignBorderAndEdges(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlignBorderAndEdges(DXW.AlignBorderAndEdges openXmlElement): base(openXmlElement) { }
  
}
