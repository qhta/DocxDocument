namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Use Move Syntax When Tracking Revisions.
/// </summary>
public partial class DoNotTrackMoves: ModelElement<DXW.DoNotTrackMoves>
{
  public DoNotTrackMoves(): base(){ }
  
  public DoNotTrackMoves(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotTrackMoves(DXW.DoNotTrackMoves openXmlElement): base(openXmlElement) { }
  
}
