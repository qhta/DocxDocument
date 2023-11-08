namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a previous table grid state, the modifications to which shall be attributed to a revision by a particular author and at a particular time. This element contains the table grid settings which were previously in place before a specific set of revisions by one author. The table grid is a definition of the set of grid columns which define all of the shared vertical edges of the table, as well as default widths for each of these grid columns. These grid column widths are then used to determine the size of the table based on the table layout algorithm used.
/// </summary>
public partial class PreviousTableGrid: ModelElement<DXW.PreviousTableGrid>
{
  public PreviousTableGrid(): base(){ }
  
  public PreviousTableGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousTableGrid(DXW.PreviousTableGrid openXmlElement): base(openXmlElement) { }
  
}
