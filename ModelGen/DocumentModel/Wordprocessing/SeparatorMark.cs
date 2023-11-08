namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote/Endnote Separator Mark.
/// </summary>
public partial class SeparatorMark: ModelElement<DXW.SeparatorMark>
{
  public SeparatorMark(): base(){ }
  
  public SeparatorMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeparatorMark(DXW.SeparatorMark openXmlElement): base(openXmlElement) { }
  
}
