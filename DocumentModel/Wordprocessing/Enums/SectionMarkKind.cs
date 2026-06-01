namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SectionMarkKind
{
  /// <summary>
  ///   Next IPage ISection IBreak.
  /// </summary>
  NextPage,

  /// <summary>
  ///   IColumn ISection IBreak.
  /// </summary>
  NextColumn,

  /// <summary>
  ///   Continuous ISection IBreak.
  /// </summary>
  Continuous,

  /// <summary>
  ///   Even IPage ISection IBreak.
  /// </summary>
  EvenPage,

  /// <summary>
  ///   Odd IPage ISection IBreak.
  /// </summary>
  OddPage
}
