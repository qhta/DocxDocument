namespace DocumentModel.Wordprocessing;


/// <summary>
///   Deleted Paragraph.
/// </summary>
public partial class Deleted: ModelElement<DXW.Deleted>
{
  public Deleted(): base(){ }
  
  public Deleted(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Deleted(DXW.Deleted openXmlElement): base(openXmlElement) { }
  
}
