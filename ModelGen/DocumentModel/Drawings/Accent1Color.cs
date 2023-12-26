namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 1 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent1Color: ModelElement<DXD.Accent1Color>
{
  public Accent1Color(): base(){ }
  
  public Accent1Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent1Color(DXD.Accent1Color openXmlElement): base(openXmlElement) { }
  
}
