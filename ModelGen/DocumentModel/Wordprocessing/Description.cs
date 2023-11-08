namespace DocumentModel.Wordprocessing;


/// <summary>
///   Description for Entry.
/// </summary>
public partial class Description: ModelElement<DXW.Description>
{
  public Description(): base(){ }
  
  public Description(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Description(DXW.Description openXmlElement): base(openXmlElement) { }
  
}
