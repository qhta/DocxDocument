namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   IAutoCorrect Entry.
  /// </summary>
  Speller,

  /// <summary>
  ///   Form IField Help Text.
  /// </summary>
  IFormField,

  /// <summary>
  ///   Structured IDocument Tag Placeholder Text.
  /// </summary>
  SdtPlaceholder
}
