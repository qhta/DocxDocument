namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 1 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Light1Color: ModelElement<DXD.Light1Color>
{
  public Light1Color(): base(){ }
  
  public Light1Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Light1Color(DXD.Light1Color openXmlElement): base(openXmlElement) { }
  
}
