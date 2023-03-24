namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FieldCharValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FieldCharKind
{
  /// <summary>
  ///   Start Character.
  /// </summary>
  Begin,

  /// <summary>
  ///   Separator Character.
  /// </summary>
  Separate,

  /// <summary>
  ///   End Character.
  /// </summary>
  End
}