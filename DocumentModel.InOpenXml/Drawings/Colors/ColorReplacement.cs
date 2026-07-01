namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color replacement effect for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorReplacement))]
[DataContract]
[XmlRoot("ColorReplacement", Namespace = "DocumentModel.Drawings")]
public partial class ColorReplacement : ColorHolder<DXD.ColorReplacement>, IExtendableElement
{

 /// <summary>
 /// List of extension elements.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}