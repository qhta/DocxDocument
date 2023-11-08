namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that any space specified before or after this paragraph, specified using the spacing element, should not be applied when the preceding and following paragraphs are of the same paragraph style, affecting the top and bottom spacing respectively.
/// </summary>
public partial class ContextualSpacing: ModelElement<DXW.ContextualSpacing>
{
  public ContextualSpacing(): base(){ }
  
  public ContextualSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContextualSpacing(DXW.ContextualSpacing openXmlElement): base(openXmlElement) { }
  
}
