namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the dark 2 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Dark2Color: ModelElement<DXD.Dark2Color>
{
  public Dark2Color(): base(){ }
  
  public Dark2Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Dark2Color(DXD.Dark2Color openXmlElement): base(openXmlElement) { }
  
}
