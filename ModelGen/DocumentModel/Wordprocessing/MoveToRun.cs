namespace DocumentModel.Wordprocessing;


/// <summary>
///   Move Destination Run Content.
/// </summary>
public partial class MoveToRun: ModelElement<DXW.MoveToRun>
{
  public MoveToRun(): base(){ }
  
  public MoveToRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveToRun(DXW.MoveToRun openXmlElement): base(openXmlElement) { }
  
}
