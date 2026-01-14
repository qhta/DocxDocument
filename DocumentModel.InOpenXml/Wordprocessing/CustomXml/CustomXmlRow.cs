namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom XML element surrounding a single table row in a WordprocessingML document.
/// This interface extends <see cref="CustomXmlElement"/>, <see cref="ITableContent"/>, and <see cref="SdtRowContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within table row content. The attributes specify the name and namespace UriString of the custom XML element.
/// </summary>
public class CustomXmlRow : CustomXmlElement, ITableContent, ISdtRowContent
{
}