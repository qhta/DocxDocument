namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 95 Full-Width Character Spacing.
/// </summary>
public partial class AutoSpaceLikeWord95: ModelElement<DXW.AutoSpaceLikeWord95>
{
  public AutoSpaceLikeWord95(): base(){ }
  
  public AutoSpaceLikeWord95(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoSpaceLikeWord95(DXW.AutoSpaceLikeWord95 openXmlElement): base(openXmlElement) { }
  
}
