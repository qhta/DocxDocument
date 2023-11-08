namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Major Tick Mark.
/// </summary>
public partial class MajorTickMark: ModelElement<DXDC.MajorTickMark>
{
  public MajorTickMark(): base(){ }
  
  public MajorTickMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorTickMark(DXDC.MajorTickMark openXmlElement): base(openXmlElement) { }
  
}
