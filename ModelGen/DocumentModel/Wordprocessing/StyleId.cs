namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the definition of a single style within a WordprocessingML document. A style is a predefined set of table, numbering, paragraph, and/or character properties which can be applied to regions within a document.
/// </summary>
public partial class StyleId: ModelElement<DXW.StyleId>
{
  public StyleId(): base(){ }
  
  public StyleId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleId(DXW.StyleId openXmlElement): base(openXmlElement) { }
  
}
