namespace DocumentModel.Wordprocessing;


/// <summary>
///   Display Page/Column Breaks Present in Frames.
/// </summary>
public partial class ShowBreaksInFrames: ModelElement<DXW.ShowBreaksInFrames>
{
  public ShowBreaksInFrames(): base(){ }
  
  public ShowBreaksInFrames(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowBreaksInFrames(DXW.ShowBreaksInFrames openXmlElement): base(openXmlElement) { }
  
}
