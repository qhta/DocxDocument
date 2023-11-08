namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Width.
/// </summary>
public partial class Width: ModelElement<DXDC.Width>
{
  public Width(): base(){ }
  
  public Width(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Width(DXDC.Width openXmlElement): base(openXmlElement) { }
  
}
