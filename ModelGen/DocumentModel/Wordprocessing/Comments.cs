namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comments Collection.
/// </summary>
public partial class Comments: ModelElement<DXW.Comments>
{
  public Comments(): base(){ }
  
  public Comments(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Comments(DXW.Comments openXmlElement): base(openXmlElement) { }
  
}
