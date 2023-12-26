namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the dark 1 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Dark1Color: ModelElement<DXD.Dark1Color>
{
  public Dark1Color(): base(){ }
  
  public Dark1Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Dark1Color(DXD.Dark1Color openXmlElement): base(openXmlElement) { }
  
}
