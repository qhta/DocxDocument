namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the top right to bottom left diagonal within the current table cell.
/// </summary>
public partial class TopRightToBottomLeftCellBorder: ModelElement<DXW.TopRightToBottomLeftCellBorder>
{
  public TopRightToBottomLeftCellBorder(): base(){ }
  
  public TopRightToBottomLeftCellBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopRightToBottomLeftCellBorder(DXW.TopRightToBottomLeftCellBorder openXmlElement): base(openXmlElement) { }
  
}
