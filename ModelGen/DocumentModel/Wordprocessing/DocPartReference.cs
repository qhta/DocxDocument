namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the name of the document part that shall be displayed in the nearest ancestor structured document tag when its run contents are empty. If this element is specified, then a document part whose name element specifies a name matching the value of this element, and which belongs to the bbPlcHdr style shall be located to be used as the placeholder text for the nearest ancestor structured document tag.
/// </summary>
public partial class DocPartReference: ModelElement<DXW.DocPartReference>
{
  public DocPartReference(): base(){ }
  
  public DocPartReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartReference(DXW.DocPartReference openXmlElement): base(openXmlElement) { }
  
}
