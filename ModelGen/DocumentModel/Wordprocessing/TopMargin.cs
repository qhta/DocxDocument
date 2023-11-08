namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed above a set of paragraphs which have the same set of paragraph border settings.
/// </summary>
public partial class TopMargin: ModelElement<DXW.TopMargin>
{
  public TopMargin(): base(){ }
  
  public TopMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopMargin(DXW.TopMargin openXmlElement): base(openXmlElement) { }
  
}
