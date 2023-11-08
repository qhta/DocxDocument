namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed below a set of paragraphs which have the same paragraph border settings.
/// </summary>
public partial class BottomMargin: ModelElement<DXW.BottomMargin>
{
  public BottomMargin(): base(){ }
  
  public BottomMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BottomMargin(DXW.BottomMargin openXmlElement): base(openXmlElement) { }
  
}
