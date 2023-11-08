namespace DocumentModel.Wordprocessing;


/// <summary>
///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
/// </summary>
public partial class AutofitToFirstFixedWidthCell: ModelElement<DXW.AutofitToFirstFixedWidthCell>
{
  public AutofitToFirstFixedWidthCell(): base(){ }
  
  public AutofitToFirstFixedWidthCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutofitToFirstFixedWidthCell(DXW.AutofitToFirstFixedWidthCell openXmlElement): base(openXmlElement) { }
  
}
