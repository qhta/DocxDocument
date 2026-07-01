namespace DocumentModel.Drawings;
/// <summary>
/// Represents the background color, supporting multiple color models and types for flexible color specification.
/// </summary>
[OpenXmlType(typeof(DXD.BackgroundColor))]
[XmlRoot("BackgroundColor", Namespace = "DocumentModel.Drawings")]
public partial class BackgroundColor : ColorHolder<DXD.BackgroundColor>
{

}