namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to a section header in a WordprocessingML document.
/// This class extends <see cref = "HeaderFooterReferenceType"/> and is used to associate a section with a specific header, enabling advanced management and referencing of headers for different sections and page types.
/// </summary>
[OpenXmlType(typeof(DXW.HeaderReference))]
[XmlRoot("HeaderReference", Namespace = "DocumentModel.Wordprocessing")]
public class HeaderReference : HeaderFooterReferenceType<DXW.HeaderReference>
{
}