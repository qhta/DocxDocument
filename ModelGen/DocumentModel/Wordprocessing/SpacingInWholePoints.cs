namespace DocumentModel.Wordprocessing;


/// <summary>
///   Only Expand/Condense Text By Whole Points.
/// </summary>
public partial class SpacingInWholePoints: ModelElement<DXW.SpacingInWholePoints>
{
  public SpacingInWholePoints(): base(){ }
  
  public SpacingInWholePoints(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpacingInWholePoints(DXW.SpacingInWholePoints openXmlElement): base(openXmlElement) { }
  
}
