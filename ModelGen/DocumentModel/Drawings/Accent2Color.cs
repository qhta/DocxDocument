namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 2 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent2Color: ModelElement<DXD.Accent2Color>
{
  public Accent2Color(): base(){ }
  
  public Accent2Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent2Color(DXD.Accent2Color openXmlElement): base(openXmlElement) { }
  
}
