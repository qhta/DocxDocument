namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the number of grid columns in the parent table's table grid.
/// </summary>
public partial class GridAfter: ModelElement<DXW.GridAfter>
{
  public GridAfter(): base(){ }
  
  public GridAfter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GridAfter(DXW.GridAfter openXmlElement): base(openXmlElement) { }
  
}
