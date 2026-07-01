namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the ValAxExtensionList Class.
/// </summary>
[OpenXmlType(typeof(DXDC.ValAxExtensionList))]
[DataContract]
[XmlRoot("ValAxExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class ValAxExtensionList : ModelElementCollection<ValAxExtension>
{
}