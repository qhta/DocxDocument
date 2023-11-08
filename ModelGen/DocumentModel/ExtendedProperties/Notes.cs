namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Number of Slides Containing Notes.
/// </summary>
public partial class Notes: ModelElement<DXEP.Notes>
{
  public Notes(): base(){ }
  
  public Notes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Notes(DXEP.Notes openXmlElement): base(openXmlElement) { }
  
}
