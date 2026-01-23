namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidthValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableWidthKind
{
  /// <summary>
  ///   nil.
  /// </summary>
  Nil,
  /// <summary>
  ///   val.
  /// </summary>
  Twips
}