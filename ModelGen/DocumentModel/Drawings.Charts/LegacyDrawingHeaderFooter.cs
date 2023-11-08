namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legacy Drawing for Headers and Footers.
/// </summary>
public partial class LegacyDrawingHeaderFooter: ModelElement<DXDC.LegacyDrawingHeaderFooter>
{
  public LegacyDrawingHeaderFooter(): base(){ }
  
  public LegacyDrawingHeaderFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegacyDrawingHeaderFooter(DXDC.LegacyDrawingHeaderFooter openXmlElement): base(openXmlElement) { }
  
}
