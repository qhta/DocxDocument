namespace DocumentModel.Wordprocessing;


/// <summary>
///   Deleted Run Content.
/// </summary>
public partial class DeletedRun: ModelElement<DXW.DeletedRun>
{
  public DeletedRun(): base(){ }
  
  public DeletedRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DeletedRun(DXW.DeletedRun openXmlElement): base(openXmlElement) { }
  
}
