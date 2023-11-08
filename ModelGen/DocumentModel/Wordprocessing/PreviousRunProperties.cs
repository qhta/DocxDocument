namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be attributed to a revision by a particular author and at a particular time. This element contains the set of properties which have been tracked as a specific set of revisions by one author.
/// </summary>
public partial class PreviousRunProperties: ModelElement<DXW.PreviousRunProperties>
{
  public PreviousRunProperties(): base(){ }
  
  public PreviousRunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousRunProperties(DXW.PreviousRunProperties openXmlElement): base(openXmlElement) { }
  
}
