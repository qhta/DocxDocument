namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum JustificationKind
{
  /// <summary>
  ///   Align Left.
  /// </summary>
  Left,

  /// <summary>
  ///   start.
  /// </summary>
  Start,

  /// <summary>
  ///   Align Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Align Right.
  /// </summary>
  Right,

  /// <summary>
  ///   end.
  /// </summary>
  End,

  /// <summary>
  ///   Justified.
  /// </summary>
  Both,

  /// <summary>
  ///   Medium Kashida Length.
  /// </summary>
  MediumKashida,

  /// <summary>
  ///   Distribute All ICharacters Equally.
  /// </summary>
  Distribute,

  /// <summary>
  ///   Align Ito IList Tab.
  /// </summary>
  NumTab,

  /// <summary>
  ///   Widest Kashida Length.
  /// </summary>
  HighKashida,

  /// <summary>
  ///   Low Kashida Length.
  /// </summary>
  LowKashida,

  /// <summary>
  ///   Thai ILanguage Justification.
  /// </summary>
  ThaiDistribute
}
