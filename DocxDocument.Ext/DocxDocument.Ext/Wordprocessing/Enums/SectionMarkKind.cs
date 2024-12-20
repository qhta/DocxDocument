namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum SectionMarkKind
{
  /// <summary>
  ///   Next Page Section Break.
  /// </summary>
  NextPage,

  /// <summary>
  ///   Column Section Break.
  /// </summary>
  NextColumn,

  /// <summary>
  ///   Continuous Section Break.
  /// </summary>
  Continuous,

  /// <summary>
  ///   Even Page Section Break.
  /// </summary>
  EvenPage,

  /// <summary>
  ///   Odd Page Section Break.
  /// </summary>
  OddPage
}