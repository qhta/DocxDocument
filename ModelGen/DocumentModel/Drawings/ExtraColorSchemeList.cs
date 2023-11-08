namespace DocumentModel.Drawings;


/// <summary>
///   This element is a container for the list of extra color schemes present in a document.
/// </summary>
public partial class ExtraColorSchemeList: ModelElement<DXD.ExtraColorSchemeList>
{
  public ExtraColorSchemeList(): base(){ }
  
  public ExtraColorSchemeList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtraColorSchemeList(DXD.ExtraColorSchemeList openXmlElement): base(openXmlElement) { }
  
}
