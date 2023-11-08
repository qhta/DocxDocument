namespace DocumentModel.Wordprocessing;


/// <summary>
///   Page Border Excludes Header.
/// </summary>
public partial class BordersDoNotSurroundHeader: ModelElement<DXW.BordersDoNotSurroundHeader>
{
  public BordersDoNotSurroundHeader(): base(){ }
  
  public BordersDoNotSurroundHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BordersDoNotSurroundHeader(DXW.BordersDoNotSurroundHeader openXmlElement): base(openXmlElement) { }
  
}
