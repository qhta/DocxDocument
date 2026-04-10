namespace DocumentModel;
/// <summary>
/// Collection of all document properties;
/// </summary>
[XmlRoot("DocumentProperties", Namespace = "DocumentModel")]
public partial class DocumentProperties : ModelElementCollection<DocumentProperty>
{
}