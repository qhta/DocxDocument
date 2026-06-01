namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the MultiLevelValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MultiLevelKind
{
  /// <summary>
  ///   Single Level Numbering Definition.
  /// </summary>
  SingleLevel,

  /// <summary>
  ///   Multilevel Numbering Definition.
  /// </summary>
  Multilevel,

  /// <summary>
  ///   Hybrid Multilevel Numbering Definition.
  /// </summary>
  HybridMultilevel
}
