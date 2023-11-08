namespace DocumentModel.Wordprocessing;


/// <summary>
///   Anchor for Subdocument Location.
/// </summary>
public partial class SubDocumentReference: ModelElement<DXW.SubDocumentReference>
{
  public SubDocumentReference(): base(){ }
  
  public SubDocumentReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubDocumentReference(DXW.SubDocumentReference openXmlElement): base(openXmlElement) { }
  
}
