namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the HiLoLine Class.
/// </summary>
public partial class HiLoLine: ModelElement<DXO13DCS.HiLoLine>
{
  public HiLoLine(): base(){ }
  
  public HiLoLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiLoLine(DXO13DCS.HiLoLine openXmlElement): base(openXmlElement) { }
  
}
