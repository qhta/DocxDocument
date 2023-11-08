namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Separator.
/// </summary>
public partial class Separator: ModelElement<DXDC.Separator>
{
  public Separator(): base(){ }
  
  public Separator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Separator(DXDC.Separator openXmlElement): base(openXmlElement) { }
  
}
