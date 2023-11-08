namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether this style shall be treated as a primary style when this document is loaded by an application. If this element is set, then this style has been designated as being particularly important for the current document, and this information can be used by an application in any means desired.
/// </summary>
public partial class PrimaryStyle: ModelElement<DXW.PrimaryStyle>
{
  public PrimaryStyle(): base(){ }
  
  public PrimaryStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrimaryStyle(DXW.PrimaryStyle openXmlElement): base(openXmlElement) { }
  
}
