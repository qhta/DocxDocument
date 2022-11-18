namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TabStopValues enumeration.
/// </summary>
public enum TabStop
{
  /// <summary>
  /// No Tab Stop.
  /// </summary>
  [XmlEnum("clear")]
  Clear,
  
  /// <summary>
  /// Left Tab.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// start.
  /// </summary>
  [XmlEnum("start")]
  Start,
  
  /// <summary>
  /// Centered Tab.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Right Tab.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// end.
  /// </summary>
  [XmlEnum("end")]
  End,
  
  /// <summary>
  /// Decimal Tab.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
  /// <summary>
  /// Bar Tab.
  /// </summary>
  [XmlEnum("bar")]
  Bar,
  
  /// <summary>
  /// List Tab.
  /// </summary>
  [XmlEnum("num")]
  Number,
  
}
