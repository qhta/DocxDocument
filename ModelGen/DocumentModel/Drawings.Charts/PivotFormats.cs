namespace DocumentModel.Drawings.Charts;


/// <summary>
///   pivot chart format persistence data.
/// </summary>
public partial class PivotFormats: ModelElement<DXDC.PivotFormats>
{
  public PivotFormats(): base(){ }
  
  public PivotFormats(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotFormats(DXDC.PivotFormats openXmlElement): base(openXmlElement) { }
  
}
