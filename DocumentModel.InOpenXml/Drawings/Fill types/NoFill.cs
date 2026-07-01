namespace DocumentModel.Drawings;
/// <summary>
///   Indicates that no fill is applied to the parent element.
/// </summary>
[OpenXmlType(typeof(DXD.NoFill))]
[DataContract]
[XmlRoot("NoFill", Namespace = "DocumentModel.Drawings")]
public class NoFill : Fill<DXD.NoFill>
{
}