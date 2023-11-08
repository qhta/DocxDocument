namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the semiHidden property shall be removed when this style is used by the content of the document. If this element is set, then an application shall ensure that even if the semiHidden element is specified on a style, that this property is removed when the document is resaved if the style is referenced by any content in the document.
/// </summary>
public partial class UnhideWhenUsed: ModelElement<DXW.UnhideWhenUsed>
{
  public UnhideWhenUsed(): base(){ }
  
  public UnhideWhenUsed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnhideWhenUsed(DXW.UnhideWhenUsed openXmlElement): base(openXmlElement) { }
  
}
