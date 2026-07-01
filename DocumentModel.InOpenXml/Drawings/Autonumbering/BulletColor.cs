using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
/// Represents a specified color for bullets, supporting multiple color models and extension options.
/// </summary>
[OpenXmlType(typeof(DXD.BulletColor))]
[XmlRoot("BulletColor", Namespace = "DocumentModel.Drawings")]
public partial class BulletColor : ColorHolder<DXD.BulletColor>, IExtendableElement
{
 /// <summary>
 /// List of extensions for the bullet color.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}