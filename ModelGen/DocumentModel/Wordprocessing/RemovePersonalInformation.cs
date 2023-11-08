namespace DocumentModel.Wordprocessing;


/// <summary>
///   Remove Personal Information from Document Properties.
/// </summary>
public partial class RemovePersonalInformation: ModelElement<DXW.RemovePersonalInformation>
{
  public RemovePersonalInformation(): base(){ }
  
  public RemovePersonalInformation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RemovePersonalInformation(DXW.RemovePersonalInformation openXmlElement): base(openXmlElement) { }
  
}
