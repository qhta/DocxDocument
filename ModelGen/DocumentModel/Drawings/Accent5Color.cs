namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 5 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent5Color: ModelElement<DXD.Accent5Color>
{
  public Accent5Color(): base(){ }
  
  public Accent5Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent5Color(DXD.Accent5Color openXmlElement): base(openXmlElement) { }
  
}
