namespace DocumentModel.Wordprocessing;


/// <summary>
///   Move Destination Paragraph.
/// </summary>
public partial class MoveTo: ModelElement<DXW.MoveTo>
{
  public MoveTo(): base(){ }
  
  public MoveTo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveTo(DXW.MoveTo openXmlElement): base(openXmlElement) { }
  
}
