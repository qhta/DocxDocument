namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the presence of a custom XML element around a single table row. 
///   The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public class CustomXmlRow: CustomXmlElement, ITableContent, ISdtRowContent
{
}