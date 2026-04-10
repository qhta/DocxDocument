namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of category axis extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.CatAxExtensionList))]
[XmlRoot("CatAxExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class CatAxExtensionList : ModelElementCollection<CatAxisExtension>
{
}