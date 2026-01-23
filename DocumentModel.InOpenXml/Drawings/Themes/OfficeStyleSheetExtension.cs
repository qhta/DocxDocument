namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for an office style sheet, providing additional theme or formatting information.
/// </summary>
[OpenXmlType(typeof(DXD.OfficeStyleSheetExtension))]
/// <summary>
///   Represents an extension for an office style sheet, providing additional theme or formatting information.
/// </summary>
public partial class OfficeStyleSheetExtension : ModelElement<DXD.OfficeStyleSheetExtension>, IExtension
{
    /// <summary>
    ///   Theme family information associated with the extension.
    /// </summary>
    [OpenXmlElement(typeof(DXO13T.ThemeFamily))]
    public ThemeFamily? ThemeFamily { get => _ThemeFamily; set => UpdateField(ref _ThemeFamily, value, nameof(ThemeFamily)); }

    private ThemeFamily? _ThemeFamily;
    /// <summary>
    /// Uri string associated with the extension.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.OfficeStyleSheetExtension.Uri))]
    public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private string? _Uri;
    public string? UriString { get => _UriString; set => UpdateField(ref _UriString, value, nameof(UriString)); }

    private string? _UriString;
}