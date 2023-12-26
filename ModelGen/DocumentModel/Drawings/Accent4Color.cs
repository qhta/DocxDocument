namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 4 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent4Color: ModelElement<DXD.Accent4Color>
{
  public Accent4Color(): base(){ }
  
  public Accent4Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent4Color(DXD.Accent4Color openXmlElement): base(openXmlElement) { }
  
}
