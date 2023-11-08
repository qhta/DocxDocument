namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Band Formats.
/// </summary>
public partial class BandFormats: ModelElement<DXDC.BandFormats>
{
  public BandFormats(): base(){ }
  
  public BandFormats(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BandFormats(DXDC.BandFormats openXmlElement): base(openXmlElement) { }
  
}
