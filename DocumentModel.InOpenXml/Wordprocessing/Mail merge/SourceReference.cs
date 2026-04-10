namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a mail merge data source reference in a WordprocessingML document, linking to the external data file used for mail merge operations.
/// </summary>
[OpenXmlType(typeof(DXW.SourceReference))]
[XmlRoot("SourceReference", Namespace = "DocumentModel.Wordprocessing")]
public class SourceReference : RelationshipType<DXW.SourceReference>
{
}