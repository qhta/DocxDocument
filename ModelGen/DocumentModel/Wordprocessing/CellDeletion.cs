namespace DocumentModel.Wordprocessing;


/// <summary>
///   Table Cell Deletion.
/// </summary>
public partial class CellDeletion: ModelElement<DXW.CellDeletion>
{
  public CellDeletion(): base(){ }
  
  public CellDeletion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CellDeletion(DXW.CellDeletion openXmlElement): base(openXmlElement) { }
  
}
