namespace DocumentModel.Wordprocessing;


/// <summary>
///   Keep Source Formatting on Import.
/// </summary>
public partial class MatchSource: ModelElement<DXW.MatchSource>
{
  public MatchSource(): base(){ }
  
  public MatchSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatchSource(DXW.MatchSource openXmlElement): base(openXmlElement) { }
  
}
