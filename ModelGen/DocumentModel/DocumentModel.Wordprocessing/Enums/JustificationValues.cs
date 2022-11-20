namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the JustificationValues enumeration.
/// </summary>
public enum JustificationValues
{
  /// <summary>
  /// Align Left.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// start.
  /// </summary>
  [XmlEnum("start")]
  Start,
  
  /// <summary>
  /// Align Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Align Right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// end.
  /// </summary>
  [XmlEnum("end")]
  End,
  
  /// <summary>
  /// Justified.
  /// </summary>
  [XmlEnum("both")]
  Both,
  
  /// <summary>
  /// Medium Kashida Length.
  /// </summary>
  [XmlEnum("mediumKashida")]
  MediumKashida,
  
  /// <summary>
  /// Distribute All Characters Equally.
  /// </summary>
  [XmlEnum("distribute")]
  Distribute,
  
  /// <summary>
  /// Align to List Tab.
  /// </summary>
  [XmlEnum("numTab")]
  NumTab,
  
  /// <summary>
  /// Widest Kashida Length.
  /// </summary>
  [XmlEnum("highKashida")]
  HighKashida,
  
  /// <summary>
  /// Low Kashida Length.
  /// </summary>
  [XmlEnum("lowKashida")]
  LowKashida,
  
  /// <summary>
  /// Thai Language Justification.
  /// </summary>
  [XmlEnum("thaiDistribute")]
  ThaiDistribute,
  
}
