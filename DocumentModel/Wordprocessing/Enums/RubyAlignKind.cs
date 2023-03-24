namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RubyAlignValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RubyAlignKind
{
  /// <summary>
  ///   Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Distribute All Characters.
  /// </summary>
  DistributeLetter,

  /// <summary>
  ///   Distribute all Characters w/ Additional Space On Either Side.
  /// </summary>
  DistributeSpace,

  /// <summary>
  ///   Left Aligned.
  /// </summary>
  Left,

  /// <summary>
  ///   Right Aligned.
  /// </summary>
  Right,

  /// <summary>
  ///   Vertically Aligned to Right of Base Text.
  /// </summary>
  RightVertical
}