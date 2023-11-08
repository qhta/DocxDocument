namespace DocumentModel.Wordprocessing;


/// <summary>
///   Track Revisions to Document.
/// </summary>
public partial class TrackRevisions: ModelElement<DXW.TrackRevisions>
{
  public TrackRevisions(): base(){ }
  
  public TrackRevisions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrackRevisions(DXW.TrackRevisions openXmlElement): base(openXmlElement) { }
  
}
