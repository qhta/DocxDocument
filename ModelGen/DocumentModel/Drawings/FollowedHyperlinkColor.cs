namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the followed hyperlink color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class FollowedHyperlinkColor: ModelElement<DXD.FollowedHyperlinkColor>
{
  public FollowedHyperlinkColor(): base(){ }
  
  public FollowedHyperlinkColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FollowedHyperlinkColor(DXD.FollowedHyperlinkColor openXmlElement): base(openXmlElement) { }
  
}
