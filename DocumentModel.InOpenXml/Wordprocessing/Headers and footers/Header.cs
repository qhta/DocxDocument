namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the content for a single header for use within one or more sections of a WordprocessingML document.
/// This class extends <see cref = "HeaderFooter"/> and contains block-level markup similar to the document body, enabling advanced management and formatting of header content for different sections and page types.
/// </summary>
[XmlRoot("Header", Namespace = "DocumentModel.Wordprocessing")]
public class Header : HeaderFooter
{
}