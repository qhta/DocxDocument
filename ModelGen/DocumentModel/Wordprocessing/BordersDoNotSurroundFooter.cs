namespace DocumentModel.Wordprocessing;


/// <summary>
///   Page Border Excludes Footer.
/// </summary>
public partial class BordersDoNotSurroundFooter: ModelElement<DXW.BordersDoNotSurroundFooter>
{
  public BordersDoNotSurroundFooter(): base(){ }
  
  public BordersDoNotSurroundFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BordersDoNotSurroundFooter(DXW.BordersDoNotSurroundFooter openXmlElement): base(openXmlElement) { }
  
}
