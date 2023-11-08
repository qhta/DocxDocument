namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Minor Tick Mark.
/// </summary>
public partial class MinorTickMark: ModelElement<DXDC.MinorTickMark>
{
  public MinorTickMark(): base(){ }
  
  public MinorTickMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorTickMark(DXDC.MinorTickMark openXmlElement): base(openXmlElement) { }
  
}
