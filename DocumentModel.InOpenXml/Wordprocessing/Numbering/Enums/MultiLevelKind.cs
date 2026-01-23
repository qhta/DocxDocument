namespace DocumentModel.Wordprocessing;

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
  ///   MultiLevelType Numbering Definition.
  /// </summary>
  Multilevel,
  /// <summary>
  ///   Hybrid MultiLevelType Numbering Definition.
  /// </summary>
  HybridMultilevel
}