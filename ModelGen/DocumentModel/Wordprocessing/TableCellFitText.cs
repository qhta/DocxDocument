namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of the current cell shall have their inter-character spacing increased or reduced as necessary to fit the width of the text extents of the current cell. This setting shall behave identically to placing the contents of this paragraph in a run and using the fitText element, if the width provided on that element matched the width of the current cell.
/// </summary>
public partial class TableCellFitText: ModelElement<DXW.TableCellFitText>
{
  public TableCellFitText(): base(){ }
  
  public TableCellFitText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellFitText(DXW.TableCellFitText openXmlElement): base(openXmlElement) { }
  
}
