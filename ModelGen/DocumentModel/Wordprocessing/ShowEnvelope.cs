namespace DocumentModel.Wordprocessing;


/// <summary>
///   Show E-Mail Message Header.
/// </summary>
public partial class ShowEnvelope: ModelElement<DXW.ShowEnvelope>
{
  public ShowEnvelope(): base(){ }
  
  public ShowEnvelope(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowEnvelope(DXW.ShowEnvelope openXmlElement): base(openXmlElement) { }
  
}
