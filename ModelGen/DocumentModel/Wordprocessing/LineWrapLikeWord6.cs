namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 6.0 Line Wrapping for East Asian Text.
/// </summary>
public partial class LineWrapLikeWord6: ModelElement<DXW.LineWrapLikeWord6>
{
  public LineWrapLikeWord6(): base(){ }
  
  public LineWrapLikeWord6(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineWrapLikeWord6(DXW.LineWrapLikeWord6 openXmlElement): base(openXmlElement) { }
  
}
