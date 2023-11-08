namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a gray scale effect. Converts all effect color values to a shade of gray, corresponding to their luminance. Effect alpha (opacity) values are unaffected.
/// </summary>
public partial class Grayscale: ModelElement<DXD.Grayscale>
{
  public Grayscale(): base(){ }
  
  public Grayscale(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Grayscale(DXD.Grayscale openXmlElement): base(openXmlElement) { }
  
}
