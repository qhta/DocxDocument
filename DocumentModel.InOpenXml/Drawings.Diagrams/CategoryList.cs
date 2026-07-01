namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category List.
/// </summary>
[OpenXmlType(typeof(DXDD.CategoryList))]
[DataContract]
[XmlRoot("CategoryList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class CategoryList : ModelElementCollection<Category, DXDD.CategoryList, DXDD.Category>
{
}