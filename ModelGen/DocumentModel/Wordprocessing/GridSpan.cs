namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the number of grid columns in the parent table's table grid which shall be spanned by the current cell. This property allows cells to have the appearance of being merged, as they span vertical boundaries of other cells in the table.
/// </summary>
public partial class GridSpan: ModelElement<DXW.GridSpan>
{
  public GridSpan(): base(){ }
  
  public GridSpan(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GridSpan(DXW.GridSpan openXmlElement): base(openXmlElement) { }
  
}
