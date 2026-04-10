namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the color mapping type for drawing elements in a WordprocessingML or DrawingML document.
///   Provides configuration for mapping theme colors to specific uses in shapes, text, and backgrounds, and supports extensibility for additional color mapping data.
/// </summary>
[OpenXmlType(typeof(DXD.ColorMappingType))]
[XmlRoot("ColorMappingType", Namespace = "DocumentModel.Wordprocessing")]
public partial class ColorMappingType : DMD.ColorMap<DXD.ColorMappingType>, IExtendableElement
{
 /// <summary>
 ///   The name of the color mapping or font scheme, used to identify the color mapping configuration for drawing elements.
 /// </summary>
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   List of extension elements for the color mapping, allowing for future extensibility and application-specific color mapping data.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMappingType.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}