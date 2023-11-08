namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the top left side to bottom right diagonal within the current table cell.
/// </summary>
public partial class TopLeftToBottomRightCellBorder: ModelElement<DXW.TopLeftToBottomRightCellBorder>
{
  public TopLeftToBottomRightCellBorder(): base(){ }
  
  public TopLeftToBottomRightCellBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopLeftToBottomRightCellBorder(DXW.TopLeftToBottomRightCellBorder openXmlElement): base(openXmlElement) { }
  
}
