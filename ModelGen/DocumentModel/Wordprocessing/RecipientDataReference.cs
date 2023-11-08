namespace DocumentModel.Wordprocessing;


/// <summary>
///   Reference to Inclusion/Exclusion Data for Data Source.
/// </summary>
public partial class RecipientDataReference: ModelElement<DXW.RecipientDataReference>
{
  public RecipientDataReference(): base(){ }
  
  public RecipientDataReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RecipientDataReference(DXW.RecipientDataReference openXmlElement): base(openXmlElement) { }
  
}
