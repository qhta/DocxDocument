namespace DocumentModel.Wordprocessing;


/// <summary>
///   Header Reference.
/// </summary>
public partial class HeaderReference: ModelElement<DXW.HeaderReference>
{
  public HeaderReference(): base(){ }
  
  public HeaderReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderReference(DXW.HeaderReference openXmlElement): base(openXmlElement) { }
  
}
