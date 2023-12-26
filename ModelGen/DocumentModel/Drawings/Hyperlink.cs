namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the hyperlink color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Hyperlink: ModelElement<DXD.Hyperlink>
{
  public Hyperlink(): base(){ }
  
  public Hyperlink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Hyperlink(DXD.Hyperlink openXmlElement): base(openXmlElement) { }
  
}
