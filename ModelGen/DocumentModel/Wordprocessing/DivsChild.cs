namespace DocumentModel.Wordprocessing;


/// <summary>
///   Child div Elements Contained within Current div.
/// </summary>
public partial class DivsChild: ModelElement<DXW.DivsChild>
{
  public DivsChild(): base(){ }
  
  public DivsChild(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DivsChild(DXW.DivsChild openXmlElement): base(openXmlElement) { }
  
}
