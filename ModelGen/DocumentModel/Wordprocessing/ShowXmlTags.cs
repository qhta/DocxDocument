namespace DocumentModel.Wordprocessing;


/// <summary>
///   Show Visual Indicators for Custom XML Markup Start/End Locations.
/// </summary>
public partial class ShowXmlTags: ModelElement<DXW.ShowXmlTags>
{
  public ShowXmlTags(): base(){ }
  
  public ShowXmlTags(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowXmlTags(DXW.ShowXmlTags openXmlElement): base(openXmlElement) { }
  
}
