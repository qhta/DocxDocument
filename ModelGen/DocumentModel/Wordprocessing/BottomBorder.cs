namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed below a set of paragraphs which have the same paragraph border settings.
/// </summary>
public partial class BottomBorder: ModelElement<DXW.BottomBorder>
{
  public BottomBorder(): base(){ }
  
  public BottomBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BottomBorder(DXW.BottomBorder openXmlElement): base(openXmlElement) { }
  
}
