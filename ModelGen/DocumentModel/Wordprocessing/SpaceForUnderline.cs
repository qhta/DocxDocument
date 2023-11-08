namespace DocumentModel.Wordprocessing;


/// <summary>
///   Add Additional Space Below Baseline For Underlined East Asian Text.
/// </summary>
public partial class SpaceForUnderline: ModelElement<DXW.SpaceForUnderline>
{
  public SpaceForUnderline(): base(){ }
  
  public SpaceForUnderline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpaceForUnderline(DXW.SpaceForUnderline openXmlElement): base(openXmlElement) { }
  
}
