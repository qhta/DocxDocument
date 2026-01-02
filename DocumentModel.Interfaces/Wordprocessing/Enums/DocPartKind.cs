namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocPartValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocPartKind
{
  /// <summary>
  ///   No Type.
  /// </summary>
  None,
  /// <summary>
  ///   Normal.
  /// </summary>
  Normal,
  /// <summary>
  ///   Automatically Replace Name With Content.
  /// </summary>
  AutoExp,
  /// <summary>
  ///   AutoText User Interface Entry.
  /// </summary>
  Toolbar,
  /// <summary>
  ///   AutoCorrect Entry.
  /// </summary>
  Speller,
  /// <summary>
  ///   Form Field Help Text.
  /// </summary>
  FormField,
  /// <summary>
  ///   Structured Document Tag Placeholder Text.
  /// </summary>
  SdtPlaceholder
}