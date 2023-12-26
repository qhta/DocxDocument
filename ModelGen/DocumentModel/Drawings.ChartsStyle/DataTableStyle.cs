namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DataTableStyle Class.
/// </summary>
public partial class DataTableStyle: ModelElement<DXO13DCS.DataTableStyle>
{
  public DataTableStyle(): base(){ }
  
  public DataTableStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataTableStyle(DXO13DCS.DataTableStyle openXmlElement): base(openXmlElement) { }
  
}
