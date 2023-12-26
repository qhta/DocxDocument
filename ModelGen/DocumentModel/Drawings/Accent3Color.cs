namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 3 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent3Color: ModelElement<DXD.Accent3Color>
{
  public Accent3Color(): base(){ }
  
  public Accent3Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent3Color(DXD.Accent3Color openXmlElement): base(openXmlElement) { }
  
}
