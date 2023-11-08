namespace DocumentModel.Wordprocessing;


/// <summary>
///   Move Source Run Content.
/// </summary>
public partial class MoveFromRun: ModelElement<DXW.MoveFromRun>
{
  public MoveFromRun(): base(){ }
  
  public MoveFromRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveFromRun(DXW.MoveFromRun openXmlElement): base(openXmlElement) { }
  
}
