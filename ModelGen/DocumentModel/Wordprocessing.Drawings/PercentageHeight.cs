namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the PercentageHeight Class.
/// </summary>
public partial class PercentageHeight: ModelElement<DXO10WD.PercentageHeight>
{
  public PercentageHeight(): base(){ }
  
  public PercentageHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PercentageHeight(DXO10WD.PercentageHeight openXmlElement): base(openXmlElement) { }
  
}
