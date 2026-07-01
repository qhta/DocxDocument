namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the WebExtensionBindingList Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtensionBindingList))]
[DataContract]
[XmlRoot("WebExtensionBindingList", Namespace = "DocumentModel.WebExtensions")]
public class WebExtensionBindingList : ModelElementCollection<WebExtensionBinding, DXO13WE.WebExtensionBindingList, DXO13WE.WebExtensionBinding>
{
}