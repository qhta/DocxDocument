namespace DocumentModel.Wordprocessing;


/// <summary>
///   Header Definition File Path.
/// </summary>
public partial class HeaderSource: ModelElement<DXW.HeaderSource>
{
  public HeaderSource(): base(){ }
  
  public HeaderSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderSource(DXW.HeaderSource openXmlElement): base(openXmlElement) { }
  
}
