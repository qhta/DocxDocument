namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 1 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Light2Color: ModelElement<DXD.Light2Color>
{
  public Light2Color(): base(){ }
  
  public Light2Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Light2Color(DXD.Light2Color openXmlElement): base(openXmlElement) { }
  
}
