namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which can be displayed on the inside edge of the paragraph when the parent's section settings specify that the section shall be printed using mirrored margins using the mirrorMargins element.
/// </summary>
public partial class BarBorder: ModelElement<DXW.BarBorder>
{
  public BarBorder(): base(){ }
  
  public BarBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarBorder(DXW.BarBorder openXmlElement): base(openXmlElement) { }
  
}
