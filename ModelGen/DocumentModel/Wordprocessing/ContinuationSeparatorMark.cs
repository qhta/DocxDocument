namespace DocumentModel.Wordprocessing;


/// <summary>
///   Continuation Separator Mark.
/// </summary>
public partial class ContinuationSeparatorMark: ModelElement<DXW.ContinuationSeparatorMark>
{
  public ContinuationSeparatorMark(): base(){ }
  
  public ContinuationSeparatorMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContinuationSeparatorMark(DXW.ContinuationSeparatorMark openXmlElement): base(openXmlElement) { }
  
}
