using DocumentModel.Drawings.Colors;
namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorScheme))]
public partial class ColorScheme : ModelElement<DXD.ColorScheme>, IExtendableElement
{
 /// <summary>
 /// FontName.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
 /// <summary>
 /// Dark 1.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorScheme.Dark1Color))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
 /// <summary>
 /// OfficeArtExtensionList.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}