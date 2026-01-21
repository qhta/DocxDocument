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
  public CompatSettingNameKind? Name { get; set; }
  /// <summary>
  /// UriString associated with the compatibility setting, identifying the namespace or context for the setting.
  /// </summary>
  public string? UriString { get; set; }
  /// <summary>
  /// Value of the compatibility setting, specifying the configuration or option value.
  /// </summary>
  public string? Val { get; set; }
}