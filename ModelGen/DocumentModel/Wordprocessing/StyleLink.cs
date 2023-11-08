namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Style Definition.
/// </summary>
public partial class StyleLink: ModelElement<DXW.StyleLink>
{
  public StyleLink(): base(){ }
  
  public StyleLink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLink(DXW.StyleLink openXmlElement): base(openXmlElement) { }
  
}
