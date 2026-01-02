namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SectionMarkKind
{
  /// <summary>
  ///   Next Page ISection Break.
  /// </summary>
  NextPage,
  /// <summary>
  ///   IColumn ISection Break.
  /// </summary>
  NextColumn,
  /// <summary>
  ///   Continuous ISection Break.
  /// </summary>
  Continuous,
  /// <summary>
  ///   Even Page ISection Break.
  /// </summary>
  EvenPage,
  /// <summary>
  ///   Odd Page ISection Break.
  /// </summary>
  OddPage
}