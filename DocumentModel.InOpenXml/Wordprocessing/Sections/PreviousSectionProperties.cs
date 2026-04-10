namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents previous section properties for a section in a Wordprocessing document.
/// This class is used to store section property settings that were in place before a specific set of revisions, enabling tracking and management of historical section configurations.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousSectionProperties))]
[XmlRoot("PreviousSectionProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousSectionProperties : BaseSectionProperties<DXW.PreviousSectionProperties>
{
}