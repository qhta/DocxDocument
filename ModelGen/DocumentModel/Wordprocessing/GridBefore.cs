namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the number of grid columns in the parent table's table grid.
/// </summary>
public partial class GridBefore: ModelElement<DXW.GridBefore>
{
  public GridBefore(): base(){ }
  
  public GridBefore(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GridBefore(DXW.GridBefore openXmlElement): base(openXmlElement) { }
  
}
