namespace DocumentModel.Wordprocessing;


/// <summary>
///   Remove Date and Time from Annotations.
/// </summary>
public partial class RemoveDateAndTime: ModelElement<DXW.RemoveDateAndTime>
{
  public RemoveDateAndTime(): base(){ }
  
  public RemoveDateAndTime(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RemoveDateAndTime(DXW.RemoveDateAndTime openXmlElement): base(openXmlElement) { }
  
}
