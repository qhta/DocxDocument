namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of the body of the document - the main document editing surface.
/// </summary>
public partial class Body: ModelElement<DXW.Body>
{
  public Body(): base(){ }
  
  public Body(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Body(DXW.Body openXmlElement): base(openXmlElement) { }
  
}
