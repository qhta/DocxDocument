namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the presence of a custom XML element around one or more 
///   inline-level structures (runs, images, fields, and so on) within a paragraph. 
///   The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public class CustomXmlRuby: CustomXmlRun, IRubyContent
{
}