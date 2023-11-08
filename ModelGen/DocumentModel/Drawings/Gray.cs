namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a grayscale of its input color, taking into relative intensities of the red, green, and blue primaries.
/// </summary>
public partial class Gray: ModelElement<DXD.Gray>
{
  public Gray(): base(){ }
  
  public Gray(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Gray(DXD.Gray openXmlElement): base(openXmlElement) { }
  
}
