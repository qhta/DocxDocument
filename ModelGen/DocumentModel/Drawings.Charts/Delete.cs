namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Delete.
/// </summary>
public partial class Delete: ModelElement<DXDC.Delete>
{
  public Delete(): base(){ }
  
  public Delete(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Delete(DXDC.Delete openXmlElement): base(openXmlElement) { }
  
}
