namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
/// </summary>
public partial class UseNormalStyleForList: ModelElement<DXW.UseNormalStyleForList>
{
  public UseNormalStyleForList(): base(){ }
  
  public UseNormalStyleForList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseNormalStyleForList(DXW.UseNormalStyleForList openXmlElement): base(openXmlElement) { }
  
}
