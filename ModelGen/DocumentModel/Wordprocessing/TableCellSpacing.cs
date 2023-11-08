namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the default table cell spacing (the spacing between adjacent cells and the edges of the table) for all cells in the parent row. If specified, this element specifies the minimum amount of space which shall be left between all cells in the table including the width of the table borders in the calculation. It is important to note that row-level cell spacing shall be added inside of the text margins, which shall be aligned with the innermost starting edge of the text extents in a cell without row-level indentation or cell spacing. Row-level cell spacing shall not increase the width of the overall table.
/// </summary>
public partial class TableCellSpacing: ModelElement<DXW.TableCellSpacing>
{
  public TableCellSpacing(): base(){ }
  
  public TableCellSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellSpacing(DXW.TableCellSpacing openXmlElement): base(openXmlElement) { }
  
}
