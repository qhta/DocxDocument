namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Track Formatting Revisions When Tracking Revisions.
/// </summary>
public partial class DoNotTrackFormatting: ModelElement<DXW.DoNotTrackFormatting>
{
  public DoNotTrackFormatting(): base(){ }
  
  public DoNotTrackFormatting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotTrackFormatting(DXW.DoNotTrackFormatting openXmlElement): base(openXmlElement) { }
  
}
