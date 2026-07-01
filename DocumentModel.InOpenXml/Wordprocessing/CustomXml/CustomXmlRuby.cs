namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom XML element surrounding one or more inline-level structures (such as runs, images, fields, etc.) within a paragraph in a WordprocessingML document.
/// This class extends <see cref = "CustomXmlRun"/> and <see cref = "IRubyContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within ruby text and other inline content. The attributes specify the name and namespace UriString of the custom XML element.
/// </summary>
[DataContract]
[XmlRoot("CustomXmlRuby", Namespace = "DocumentModel.Wordprocessing")]
public class CustomXmlRuby : CustomXmlRun, IRubyContent
{
}