namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RubyAlignValues enumeration.
/// </summary>
public enum RubyAlignKind
{
  /// <summary>
  /// Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Distribute All Characters.
  /// </summary>
  [XmlEnum("distributeLetter")]
  DistributeLetter,
  
  /// <summary>
  /// Distribute all Characters w/ Additional Space On Either Side.
  /// </summary>
  [XmlEnum("distributeSpace")]
  DistributeSpace,
  
  /// <summary>
  /// Left Aligned.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Right Aligned.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Vertically Aligned to Right of Base Text.
  /// </summary>
  [XmlEnum("rightVertical")]
  RightVertical,
  
}
