namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed between each paragraph in a set of paragraphs which have the same set of paragraph border settings.
/// </summary>
public partial class BetweenBorder: ModelElement<DXW.BetweenBorder>
{
  public BetweenBorder(): base(){ }
  
  public BetweenBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BetweenBorder(DXW.BetweenBorder openXmlElement): base(openXmlElement) { }
  
}
