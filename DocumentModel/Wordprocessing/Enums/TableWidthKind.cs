namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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