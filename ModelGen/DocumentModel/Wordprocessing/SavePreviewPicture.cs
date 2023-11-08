namespace DocumentModel.Wordprocessing;


/// <summary>
///   Generate Thumbnail For Document On Save.
/// </summary>
public partial class SavePreviewPicture: ModelElement<DXW.SavePreviewPicture>
{
  public SavePreviewPicture(): base(){ }
  
  public SavePreviewPicture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SavePreviewPicture(DXW.SavePreviewPicture openXmlElement): base(openXmlElement) { }
  
}
