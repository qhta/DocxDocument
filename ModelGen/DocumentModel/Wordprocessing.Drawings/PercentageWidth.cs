namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the PercentageWidth Class.
/// </summary>
public partial class PercentageWidth: ModelElement<DXO10WD.PercentageWidth>
{
  public PercentageWidth(): base(){ }
  
  public PercentageWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PercentageWidth(DXO10WD.PercentageWidth openXmlElement): base(openXmlElement) { }
  
}
