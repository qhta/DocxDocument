namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Selection.
/// </summary>
public partial class Selection: ModelElement<DXDC.Selection>
{
  public Selection(): base(){ }
  
  public Selection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Selection(DXDC.Selection openXmlElement): base(openXmlElement) { }
  
}
