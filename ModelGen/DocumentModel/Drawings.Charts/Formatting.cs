namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Formatting.
/// </summary>
public partial class Formatting: ModelElement<DXDC.Formatting>
{
  public Formatting(): base(){ }
  
  public Formatting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Formatting(DXDC.Formatting openXmlElement): base(openXmlElement) { }
  
}
