namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Snap to Document Grid in Table Cells with Objects.
/// </summary>
public partial class DoNotSnapToGridInCell: ModelElement<DXW.DoNotSnapToGridInCell>
{
  public DoNotSnapToGridInCell(): base(){ }
  
  public DoNotSnapToGridInCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotSnapToGridInCell(DXW.DoNotSnapToGridInCell openXmlElement): base(openXmlElement) { }
  
}
