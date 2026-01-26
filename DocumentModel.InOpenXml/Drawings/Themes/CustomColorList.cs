namespace DocumentModel.Drawings;
/// <summary>
/// Defines a list of custom colors for drawing elements.
/// </summary>
[OpenXmlType(typeof(CustomColor))]
public partial class CustomColorList : ModelElementCollection<CustomColor, DXD.CustomColorList, DXD.CustomColor>, IExtendableElement
{
 public ExtensionList? ExtensionList { get; set; }
}