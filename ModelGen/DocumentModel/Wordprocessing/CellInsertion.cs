namespace DocumentModel.Wordprocessing;


/// <summary>
///   Table Cell Insertion.
/// </summary>
public partial class CellInsertion: ModelElement<DXW.CellInsertion>
{
  public CellInsertion(): base(){ }
  
  public CellInsertion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CellInsertion(DXW.CellInsertion openXmlElement): base(openXmlElement) { }
  
}
