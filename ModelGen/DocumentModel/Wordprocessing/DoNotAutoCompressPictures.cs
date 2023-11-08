namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Automatically Compress Images.
/// </summary>
public partial class DoNotAutoCompressPictures: ModelElement<DXW.DoNotAutoCompressPictures>
{
  public DoNotAutoCompressPictures(): base(){ }
  
  public DoNotAutoCompressPictures(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotAutoCompressPictures(DXW.DoNotAutoCompressPictures openXmlElement): base(openXmlElement) { }
  
}
