namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtensionReferenceList))]
[DataContract]
[XmlRoot("WebExtensionReferenceList", Namespace = "DocumentModel.WebExtensions")]
public class WebExtensionReferenceList : ModelElementCollection<WebExtensionStoreReference, DXO13WE.WebExtensionReferenceList, DXO13WE.WebExtensionStoreReference>
{
}