namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Category List.
/// </summary>
public partial class CategoryList: ModelElement<DXDDD.CategoryList>
{
  public CategoryList(): base(){ }
  
  public CategoryList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryList(DXDDD.CategoryList openXmlElement): base(openXmlElement) { }
  
}
