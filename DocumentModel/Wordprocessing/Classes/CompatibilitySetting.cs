namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public class CompatibilitySetting: ModelElement
{
  /// <summary>
  ///   name
  /// </summary>
  public CompatSettingNameKind? Name { get; set; }

  /// <summary>
  ///   uri
  /// </summary>
  public String? Uri { get; set; }

  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }
}