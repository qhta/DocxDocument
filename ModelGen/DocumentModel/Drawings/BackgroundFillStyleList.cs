namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a list of background fills that are used within a theme.  The background fills consist of three fills, arranged in order from subtle to moderate to intense.
/// </summary>
public partial class BackgroundFillStyleList: ModelElement<DXD.BackgroundFillStyleList>
{
  public BackgroundFillStyleList(): base(){ }
  
  public BackgroundFillStyleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundFillStyleList(DXD.BackgroundFillStyleList openXmlElement): base(openXmlElement) { }
  
}
