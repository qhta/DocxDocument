namespace DocumentModel.Drawings;
/// <summary>
///   Represents a duotone effect, allowing colorization using two colors specified in various color models.
/// </summary>
[OpenXmlType(typeof(DXD.Duotone))]
[XmlRoot("Duotone", Namespace = "DocumentModel.Drawings")]
public partial class Duotone : ColorHolder<DXD.Duotone>
{
}