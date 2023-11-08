namespace DocumentModel.Wordprocessing;


/// <summary>
///   Move Source Paragraph.
/// </summary>
public partial class MoveFrom: ModelElement<DXW.MoveFrom>
{
  public MoveFrom(): base(){ }
  
  public MoveFrom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveFrom(DXW.MoveFrom openXmlElement): base(openXmlElement) { }
  
}
