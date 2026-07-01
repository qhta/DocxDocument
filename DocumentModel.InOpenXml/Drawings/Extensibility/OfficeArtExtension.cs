namespace DocumentModel;
/// <summary>
///   Represents an Office Art (DrawingML) extension element, used to store application-specific or future extensibility data in DrawingML documents.
/// </summary>
[OpenXmlType(typeof(DXD.Extension))]
[DataContract]
[XmlRoot("OfficeArtExtension", Namespace = "DocumentModel")]
public class OfficeArtExtension : ModelElement<DXD.Extension>
{
}