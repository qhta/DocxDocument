namespace DocumentModel.Wordprocessing;

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