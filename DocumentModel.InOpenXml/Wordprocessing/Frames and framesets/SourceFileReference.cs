namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to a source file for a frame in a WordprocessingML document.
/// This class extends <see cref = "ExternalFile"/> and is used to specify the external file that provides content for a frame, enabling advanced integration of external resources within document frames.
/// </summary>
[OpenXmlType(typeof(DXW.SourceFileReference))]
[XmlRoot("SourceFileReference", Namespace = "DocumentModel.Wordprocessing")]
public class SourceFileReference : RelationshipType<DXW.SourceFileReference>
{
}