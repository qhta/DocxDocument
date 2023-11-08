namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the end of cell glyph shall influence the height of the given table row in the table. If it is specified, then only printing characters in this cell shall be used to determine the row height.
/// </summary>
public partial class HideMark: ModelElement<DXW.HideMark>
{
  public HideMark(): base(){ }
  
  public HideMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HideMark(DXW.HideMark openXmlElement): base(openXmlElement) { }
  
}
