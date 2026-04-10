namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of footnote separator references in a WordprocessingML document.
/// This class provides access to and management of <see cref = "FootnoteSeparator"/> objects, enabling advanced organization and referencing of footnote separators for visual separation and formatting of footnote content.
/// </summary>
[OpenXmlType(typeof(FootnoteSeparator))]
[XmlRoot("FootnoteSeparators", Namespace = "DocumentModel.Wordprocessing")]
public class FootnoteSeparators : ElementCollection<FootnoteSeparator>
{
}