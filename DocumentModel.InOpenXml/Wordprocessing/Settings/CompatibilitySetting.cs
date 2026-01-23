namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a compatibility setting for a Wordprocessing document.
/// This class provides properties for the setting name, UriString, and value, enabling advanced configuration and management of compatibility options for document processing and rendering.
/// </summary>
public partial class CompatibilitySetting : ModelElement<DXW.CompatibilitySetting>
{
    /// <summary>
    /// Name of the compatibility setting, specifying the type of compatibility option.
    /// </summary>
    public CompatSettingNameKind? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private CompatSettingNameKind? _Name;
    /// <summary>
    /// UriString associated with the compatibility setting, identifying the namespace or context for the setting.
    /// </summary>
    public string? UriString { get => _UriString; set => UpdateField(ref _UriString, value, nameof(UriString)); }

    private string? _UriString;
    /// <summary>
    /// Value of the compatibility setting, specifying the configuration or option value.
    /// </summary>
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
}