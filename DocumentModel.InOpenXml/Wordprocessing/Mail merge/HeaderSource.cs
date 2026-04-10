namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a mail merge header source reference in a WordprocessingML document, linking to the external data file that contains header information for mail merge operations.
/// </summary>
[OpenXmlType(typeof(DXW.HeaderSource))]
[XmlRoot("HeaderSource", Namespace = "DocumentModel.Wordprocessing")]
public class HeaderSource : RelationshipType<DXW.HeaderSource>
{
}