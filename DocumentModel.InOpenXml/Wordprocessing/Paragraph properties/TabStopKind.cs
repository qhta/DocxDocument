namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TabStopValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TabStopKind
{
  /// <summary>
  ///   No Tab Stop.
  /// </summary>
  Clear,
  /// <summary>
  ///   Left Tab.
  /// </summary>
  Left,
  /// <summary>
  ///   start.
  /// </summary>
  Start,
  /// <summary>
  ///   Centered Tab.
  /// </summary>
  Center,
  /// <summary>
  ///   Right Tab.
  /// </summary>
  Right,
  /// <summary>
  ///   end.
  /// </summary>
  End,
  /// <summary>
  ///   Decimal Tab.
  /// </summary>
  Decimal,
  /// <summary>
  ///   Bar Tab.
  /// </summary>
  Bar,
  /// <summary>
  ///   List Tab.
  /// </summary>
  Number
}