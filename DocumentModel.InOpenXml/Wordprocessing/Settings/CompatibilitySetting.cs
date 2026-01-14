namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a compatibility setting for a Wordprocessing document.
/// This class provides properties for the setting name, URI, and value, enabling advanced configuration and management of compatibility options for document processing and rendering.
/// </summary>
public class CompatibilitySetting : CollectionItem
{
  
  /// <summary>
  /// Name of the compatibility setting, specifying the type of compatibility option.
  /// </summary>
  public CompatSettingNameKind? Name { get; set; }
  
  /// <summary>
  /// URI associated with the compatibility setting, identifying the namespace or context for the setting.
  /// </summary>
  public string? Uri { get; set; }
  
  /// <summary>
  /// Value of the compatibility setting, specifying the configuration or option value.
  /// </summary>
  public string? Val { get; set; }
}