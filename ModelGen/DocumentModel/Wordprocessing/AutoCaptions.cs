namespace DocumentModel.Wordprocessing;


/// <summary>
///   Automatic Captioning Settings.
/// </summary>
public partial class AutoCaptions: ModelElement<DXW.AutoCaptions>
{
  public AutoCaptions(): base(){ }
  
  public AutoCaptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoCaptions(DXW.AutoCaptions openXmlElement): base(openXmlElement) { }
  
}
