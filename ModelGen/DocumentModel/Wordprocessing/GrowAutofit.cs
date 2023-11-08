namespace DocumentModel.Wordprocessing;


/// <summary>
///   Allow Tables to AutoFit Into Page Margins.
/// </summary>
public partial class GrowAutofit: ModelElement<DXW.GrowAutofit>
{
  public GrowAutofit(): base(){ }
  
  public GrowAutofit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GrowAutofit(DXW.GrowAutofit openXmlElement): base(openXmlElement) { }
  
}
