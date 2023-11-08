namespace DocumentModel.Wordprocessing;


/// <summary>
///   Add Document Grid Line Pitch To Lines in Table Cells.
/// </summary>
public partial class AdjustLineHeightInTable: ModelElement<DXW.AdjustLineHeightInTable>
{
  public AdjustLineHeightInTable(): base(){ }
  
  public AdjustLineHeightInTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustLineHeightInTable(DXW.AdjustLineHeightInTable openXmlElement): base(openXmlElement) { }
  
}
