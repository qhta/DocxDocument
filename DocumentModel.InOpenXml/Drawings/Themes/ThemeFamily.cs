namespace DocumentModel;
/// <summary>
/// Represents a theme family definition for Office documents, supporting identification, versioning, and extension metadata for advanced theme management scenarios.
/// </summary>
/// <remarks>
/// This class provides properties for theme family name, unique identifiers, versioning, and OfficeArt extension metadata. It enables flexible theme organization, compatibility management, and extensibility for Office document processing and customization.
/// </remarks>
/// <summary>
/// Represents a theme family definition for Office documents, supporting identification, versioning, and extension metadata for advanced theme management scenarios.
/// </summary>
/// <remarks>
/// This class provides properties for theme family name, unique identifiers, versioning, and OfficeArt extension metadata. It enables flexible theme organization, compatibility management, and extensibility for Office document processing and customization.
/// </remarks>
[OpenXmlType(typeof(DXO13T.ThemeFamily))]
public partial class ThemeFamily : ModelElement<DXO13T.ThemeFamily>
{
    /// <summary>
    /// FontName of the theme family.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13T.ThemeFamily.Name))]
    /// <summary>
    /// FontName of the theme family.
    /// </summary>
    [OpenXmlElement(typeof(DXO13T.ThemeFamily))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Unique identifier for the theme family.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13T.ThemeFamily.Id))]
    /// <summary>
    /// Unique identifier for the theme family.
    /// </summary>
    [OpenXmlElement(typeof(DXO13T.ThemeFamily))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    /// Version identifier for the theme family.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13T.ThemeFamily.Vid))]
    /// <summary>
    /// Version identifier for the theme family.
    /// </summary>
    [OpenXmlElement(typeof(DXO13T.ThemeFamily))]
    public string? Vid { get => _Vid; set => UpdateField(ref _Vid, value, nameof(Vid)); }

    private string? _Vid;
    /// <summary>
    /// OfficeArt extension metadata for the theme family.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13T.ThemeFamily.OfficeArtExtensionList))]
    /// <summary>
    /// OfficeArt extension metadata for the theme family.
    /// </summary>
    [OpenXmlElement(typeof(DXO13T.ThemeFamily))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}