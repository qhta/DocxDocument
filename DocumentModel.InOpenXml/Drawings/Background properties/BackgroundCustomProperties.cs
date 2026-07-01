namespace DocumentModel.Drawings;
/// <summary>
/// Represents custom background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
[OpenXmlType(typeof(DXO21DL.BackgroundCustomProperties))]
[DataContract]
[XmlRoot("BackgroundCustomProperties", Namespace = "DocumentModel.Drawings")]
public class BackgroundCustomProperties : ModelElement<DXO21DL.BackgroundCustomProperties>
{
}