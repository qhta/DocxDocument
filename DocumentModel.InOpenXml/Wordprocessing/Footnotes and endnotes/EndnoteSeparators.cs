namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of endnote separator references in a WordprocessingML document.
/// This class provides access to and management of <see cref = "EndnoteSeparator"/> objects, enabling advanced organization and referencing of endnote separators for visual separation and formatting of endnote content.
/// </summary>
[OpenXmlType(typeof(EndnoteSeparator))]
public class EndnoteSeparators : ElementCollection<EndnoteSeparator>
{
}