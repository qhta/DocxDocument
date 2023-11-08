namespace DocumentModel.Wordprocessing;


/// <summary>
///   Only Save Custom XML Markup.
/// </summary>
public partial class SaveXmlDataOnly: ModelElement<DXW.SaveXmlDataOnly>
{
  public SaveXmlDataOnly(): base(){ }
  
  public SaveXmlDataOnly(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveXmlDataOnly(DXW.SaveXmlDataOnly openXmlElement): base(openXmlElement) { }
  
}
