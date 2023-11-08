namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on all horizontal table cell borders which are not on an outmost edge of the parent table (all horizontal borders which are not the topmost or bottommost border). The appearance of this table cell border in the document shall be determined by the following settings:
/// </summary>
public partial class InsideHorizontalBorder: ModelElement<DXW.InsideHorizontalBorder>
{
  public InsideHorizontalBorder(): base(){ }
  
  public InsideHorizontalBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InsideHorizontalBorder(DXW.InsideHorizontalBorder openXmlElement): base(openXmlElement) { }
  
}
