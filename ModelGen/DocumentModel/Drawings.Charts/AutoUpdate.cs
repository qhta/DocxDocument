namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Update Automatically.
/// </summary>
public partial class AutoUpdate: ModelElement<DXDC.AutoUpdate>
{
  public AutoUpdate(): base(){ }
  
  public AutoUpdate(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoUpdate(DXDC.AutoUpdate openXmlElement): base(openXmlElement) { }
  
}
