namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the CategoryAxis Class.
/// </summary>
public partial class CategoryAxis: ModelElement<DXO13DCS.CategoryAxis>
{
  public CategoryAxis(): base(){ }
  
  public CategoryAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryAxis(DXO13DCS.CategoryAxis openXmlElement): base(openXmlElement) { }
  
}
