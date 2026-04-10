namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for an Office style sheet in DrawingML, providing additional theme or formatting information for document themes.
///   Enables advanced customization and extensibility of theme definitions, including theme family metadata and URI association.
/// </summary>
[OpenXmlType(typeof(DXD.OfficeStyleSheetExtension))]
[XmlRoot("OfficeStyleSheetExtension", Namespace = "DocumentModel.Drawings")]
public partial class OfficeStyleSheetExtension : ModelElement<DXD.OfficeStyleSheetExtension>, IExtension
{
 /// <summary>
 ///   Theme family information associated with the extension, describing the family or category of the theme for compatibility and grouping.
 /// </summary>
 public ThemeFamily? ThemeFamily { get => _ThemeFamily; set => UpdateField(ref _ThemeFamily, value, nameof(ThemeFamily)); }

 private ThemeFamily? _ThemeFamily;
 /// <summary>
 ///   URI string associated with the extension, identifying the extension type or schema for the theme extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OfficeStyleSheetExtension.Uri))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
 /// <summary>
 ///   Additional URI string for the extension, used for custom or application-specific extension identification.
 /// </summary>
 public string? UriString { get => _UriString; set => UpdateField(ref _UriString, value, nameof(UriString)); }

 private string? _UriString;
}