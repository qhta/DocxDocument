namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether this style shall be hidden from the main user interface when this document is loaded by an application. If this element is set, then this style can be used to format content (i.e. any content which references this style shall have its properties as normal), but the style shall be hidden from the main user interface associated with that application.
/// </summary>
public partial class SemiHidden: ModelElement<DXW.SemiHidden>
{
  public SemiHidden(): base(){ }
  
  public SemiHidden(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SemiHidden(DXW.SemiHidden openXmlElement): base(openXmlElement) { }
  
}
