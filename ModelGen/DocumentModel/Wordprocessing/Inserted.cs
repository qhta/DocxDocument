namespace DocumentModel.Wordprocessing;


/// <summary>
///   Inserted Paragraph.
/// </summary>
public partial class Inserted: ModelElement<DXW.Inserted>
{
  public Inserted(): base(){ }
  
  public Inserted(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Inserted(DXW.Inserted openXmlElement): base(openXmlElement) { }
  
}
