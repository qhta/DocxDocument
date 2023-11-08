namespace DocumentModel.Word13;


/// <summary>
///   This element specifies contact information for each person who is the author of at least one comment or revision in the current document.
/// </summary>
public partial class People: ModelElement<DXO13W.People>
{
  public People(): base(){ }
  
  public People(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public People(DXO13W.People openXmlElement): base(openXmlElement) { }
  
}
