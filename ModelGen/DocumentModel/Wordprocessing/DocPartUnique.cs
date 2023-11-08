namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that this structured document tag is being used to encapsulate a built-in document part (i.e. this element appears as a child element of the docPartObj element).
/// </summary>
public partial class DocPartUnique: ModelElement<DXW.DocPartUnique>
{
  public DocPartUnique(): base(){ }
  
  public DocPartUnique(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartUnique(DXW.DocPartUnique openXmlElement): base(openXmlElement) { }
  
}
