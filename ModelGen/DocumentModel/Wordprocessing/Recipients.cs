namespace DocumentModel.Wordprocessing;


/// <summary>
///   Inclusion/Exclusion Data for Data Source.
/// </summary>
public partial class Recipients: ModelElement<DXW.Recipients>
{
  public Recipients(): base(){ }
  
  public Recipients(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Recipients(DXW.Recipients openXmlElement): base(openXmlElement) { }
  
}
