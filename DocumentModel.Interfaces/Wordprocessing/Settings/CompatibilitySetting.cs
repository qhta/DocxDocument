namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public interface CompatibilitySetting: IModelElement
{
  /// <summary>
  ///   name
  /// </summary>
  public CompatSettingNameKind? Name { get; set; }
  /// <summary>
  ///   uri
  /// </summary>
  public string? Uri { get; set; }
  /// <summary>
  ///   val
  /// </summary>
  public string? Val { get; set; }
}