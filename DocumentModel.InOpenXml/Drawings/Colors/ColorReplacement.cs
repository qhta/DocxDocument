namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color replacement effect for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorReplacement))]
[XmlRoot("ColorReplacement", Namespace = "DocumentModel.Drawings")]
public partial class ColorReplacement : DrawingsColorBase<DXD.ColorReplacement>, IExtendableElement
{

 /// <summary>
 /// List of extension elements.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}